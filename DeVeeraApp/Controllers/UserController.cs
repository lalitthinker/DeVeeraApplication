﻿using System;
using System.Collections.Generic;
using System.Linq;

using CRM.Core.Domain.Users;
using CRM.Services.Common;
using CRM.Services.Users;
using CRM.Services.Directory;
using CRM.Services.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRM.Core.Domain.Common;
using CRM.Services.Authentication;
using DeVeeraApp.Factories;
using CRM.Services.Security;
using DeVeeraApp.Model.Common;
using Microsoft.AspNetCore.Mvc.Filters;
using CRM.Core;

using CRM.Core.Domain.Directory;
using DeVeeraApp.ViewModels.User;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels.UserLogin;

namespace DeVeeraApp.Controllers
{

    public class UserController : BaseController
    {
        #region fields

        private readonly IUserService _UserService;
        private readonly IUserModelFactory _UserModelFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAuthenticationService _authenticationService;
        private readonly IAddressService _addressService;
        private readonly ICountryService _countryService;
        private readonly IStateProvinceService _stateProvinceService;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly IUserPasswordService _Userpasswordservice;
        private readonly IUserRegistrationService _UserRegistrationService;
        private readonly IPermissionService _permissionService;
        private readonly IWorkContext _WorkContextService;
        //private readonly INotificationService _notificationService;
        private readonly IEncryptionService _encryptionService;

        #endregion

        #region CTOR
        public UserController(IHttpContextAccessor httpContextAccessor,
                                  IWorkContext WorkContextService,
                                  IUserPasswordService Userpasswordservice,
                                  IUserService UserService,
                                  IAddressService addressService,
                                  ICountryService countryService,
                                  IStateProvinceService stateProvinceService,
                                  IDateTimeHelper dateTimeHelper,
                                  IPermissionService permissionService,
                                  IUserRegistrationService UserRegistrationService,
                                  IAuthenticationService authenticationService,
                                  IUserModelFactory UserModelFactory,
                                 // INotificationService notificationService,
                                  IEncryptionService encryptionService
                                ) : base(
                                    workContext: WorkContextService,
                                    httpContextAccessor: httpContextAccessor,
                                    authenticationService: authenticationService)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._WorkContextService = WorkContextService;
            this._UserService = UserService;
            this._addressService = addressService;
            this._countryService = countryService;
            this._stateProvinceService = stateProvinceService;
            this._dateTimeHelper = dateTimeHelper;
            this._Userpasswordservice = Userpasswordservice;
            this._UserRegistrationService = UserRegistrationService;
            this._authenticationService = authenticationService;
            this._UserModelFactory = UserModelFactory;
            this._permissionService = permissionService;
           // this._notificationService = notificationService;
            _encryptionService = encryptionService;
            
    }

        #endregion

        #region Utilities
       
        protected virtual void PrepareUserDataModel(UserModel model)
        {
            model.AvailableUserRoles.Add(new SelectListItem { Text = "Select Roles", Value = "0" });

            foreach (var c in _UserService.GetAllUserRoles(showHidden: true).Where(a => a.Name != "Technician"))
            {
                model.AvailableUserRoles.Add(new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                    Selected = c.Id == model.UserRoleId
                });
            }

            model.AvailableUsers.Add(new SelectListItem { Text = "Select Division", Value = "0" });
            foreach (var c in _UserService.GetAllUsers().Where(a => a.UserRole.Name == "User"))
            {
                model.AvailableUsers.Add(new SelectListItem
                {
                    Text = c.UserAddress.FirstName + " " + c.UserAddress.LastName + " ( " + c.Email + " )",
                    Value = c.Id.ToString(),
                    Selected = c.Id == model.Id

                });
            }
            //countries
            model.AvailableCountries.Add(new SelectListItem { Text = "Select Country", Value = "0" });

            foreach (var c in _countryService.GetAllCountries(showHidden: true))
            {
                model.AvailableCountries.Add(new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString(),
                    Selected = c.Id == ((model.UserAddress != null) ? model.UserAddress.CountryId : 0)
                });
            }

            //states
            List<StateProvince> states = new List<StateProvince>();
            if (model.UserAddress != null)
            {
                if(model.UserAddress.CountryId != null)
                states = _stateProvinceService.GetStateProvincesByCountryId((int)model.UserAddress.CountryId).ToList();
            }


            if (states.Any())
            {
                model.AvailableStates.Add(new SelectListItem { Text = "Select State", Value = null });

                foreach (var s in states)
                {
                    model.AvailableStates.Add(new SelectListItem
                    {
                        Text = s.Name,
                        Value = s.Id.ToString(),
                        Selected = s.Id == model.UserAddress.StateProvinceId
                    });
                }
            }
            else
            {
                var anyCountrySelected = model.AvailableCountries.Any(x => x.Selected);

                model.AvailableStates.Add(new SelectListItem
                {
                    Text = "Select State",
                    Value = null
                });
            }


        }
        protected virtual void PrepareUserModel(UserModel model, User User, bool excludeProperties, bool prepareEntireAddressModel)
        {

            if (model == null)
                throw new ArgumentNullException(nameof(model));
          


        }

        protected virtual void PrepareUserPasswordModel(UserModel model, User User, bool excludeProperties, bool prepareEntireAddressModel)
        {

            if (model == null)
                throw new ArgumentNullException(nameof(model));
            var password = _Userpasswordservice.GetPasswordByUserId(User != null ? User.Id : 0);
            if (User != null)
            {
                if (!excludeProperties)
                {
                    if (password != null)
                    {
                        model.UserPassword = password;
                    }
                }
            }


        }


        // POST: Order/GetUserById
        [HttpPost]
        public IActionResult GetUserById(int ID)
        {
            var model = _UserService.GetUserById(ID);
            UserAddressViewModel UserModelResponse = new UserAddressViewModel();
            try
            {
                UserModelResponse.UserAddress =
                    new AddressViewModel()
                    {
                        Address1 = model.UserAddress.Address1,
                        Address2 = model.UserAddress.Address2,
                        Companyname = model.UserAddress.CompanyName,
                        City = model.UserAddress.City,
                        Email = model.UserAddress.Email,
                        FirstName = model.UserAddress.FirstName,
                        LastName = model.UserAddress.LastName,
                        PhoneNumber = model.UserAddress.PhoneNumber,
                        CountryId = model.UserAddress.CountryId,
                        StateProvinceId = model.UserAddress.StateProvinceId,
                        ZipPostalCode = model.UserAddress.ZipPostalCode

                    };
            }
            catch (Exception ex)
            {

            }

            return Json(UserModelResponse);
        }

        [HttpPost]
        public IActionResult GetUserRoleById(int ID)
        {
            var model = _UserService.GetUserRoleById(ID);
            UserRoleModel roleModel = new UserRoleModel();
            try
            {
                roleModel.Name = model.Name;

            }
            catch (Exception ex)
            {

            }

            return Json(roleModel);
        }


        // POST: Order/Create
        [HttpPost]
        public IActionResult GetStateByCountryId(int Id, int SelectedId)
        {
            List<SelectListItem> States = new List<SelectListItem>();
            //states
            var states = _stateProvinceService.GetStateProvincesByCountryId(Id).ToList();
            if (states.Any())
            {
                States.Add(new SelectListItem { Text = "Select State", Value = null });

                foreach (var s in states)
                {
                    States.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString(), Selected = (s.Id == SelectedId) });
                }
            }

            return Json(States);
        }



        #endregion

        #region User

      

        //edit User
        public IActionResult CreateUser()
        {
            UserListModel model = new UserListModel();

            if (HttpContext.Session.GetInt32("isMaintenance") == null)
                return Logout();

         //   ViewBag.ActiveMenu = "Users";

         //   AddBreadcrumbs("User", "Create", "/User/UserList", "/User/CreateUser");

            if (!_permissionService.Authorize(StandardPermissionProvider.ManageUser))
                return AccessDeniedView();

            PrepareUserDataModel(model.UserData);

            return View(model);

        }


     

        [HttpPost]
        public IActionResult CreateUser(UserListModel model)
        {
           
            if (HttpContext.Session.GetInt32("isMaintenance") == null)
                return Logout();
            ViewBag.FormName = "User List";
            AddBreadcrumbs("User", "Create", "/User/UserList", "/User/CreateUser");
            //permissions

            if (!_permissionService.Authorize(StandardPermissionProvider.ManageUser))
                return AccessDeniedView();
            var custdata = new User();
            try
            {
                var formData = this.Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());

                User User = null;
                UserPassword password = null;
                if (model.UserData.Id == 0)
                {
                    if (!string.IsNullOrWhiteSpace(model.UserData.UserAddress.Email))
                    {
                        //model.Phone = model.UserAddress.PhoneNumber;
                        User = _UserService.GetUserByEmail(model.UserData.UserAddress.Email);
                        if (User != null)
                        {
                            ModelState.AddModelError("UserData.UserAddress.Email", "Email Already Exists");
                            PrepareUserDataModel(model.UserData);
                            return View(model);                         
                        }
                    }
                }

                if (model.UserData.UserRoleId == 0)
                {
                    ModelState.AddModelError("UserData.UserRoleId", "Please Select UserRole");
                }
               

                if (ModelState.IsValid)
                {
                    if (model.UserData.Id == 0)
                    {
                      
                        string RoleName = _WorkContextService.CurrentUser.UserRole.Name;

                        var user = model.UserData.ToEntity<User>();

                        user.UserGuid = Guid.NewGuid();
                        user.Email = model.UserData.UserAddress.Email;
                        user.Username = model.UserData.UserAddress.Email;
                        user.UserRoleId = (RoleName == "User") ? _WorkContextService.CurrentUser.UserRole.Id : model.UserData.UserRoleId;
                        user.Active = true;
                        user.CreatedOnUtc = DateTime.UtcNow;
                        user.LastActivityDateUtc = DateTime.UtcNow;
                        user.ParentUserId = _WorkContextService.CurrentUser.Id;
                        user.Alias = model.UserData.Alias;

                        _UserService.InsertUser(user);
                
                        // password
                        if (!string.IsNullOrWhiteSpace(model.UserData.UserPassword.Password))
                        {
                            password = new UserPassword
                            {
                                UserId = user.Id,
                                Password = model.UserData.UserPassword.Password,
                                CreatedOnUtc = DateTime.UtcNow,
                                //default passwordFormat
                                PasswordFormat = PasswordFormat.Clear

                            };
                            _Userpasswordservice.InsertUserPassword(password);
                        }

                    }
                    else
                    {
                      
                        return Json(model);
                    }


                    // _notificationService.SuccessNotification("New User has been added successfully.");
                    return RedirectToAction("User", "Login");

                }
                else

                {
                    PrepareUserDataModel(model.UserData);
                    
                    var ErrorMessage = string.Join("\n", ModelState.Values
                            .SelectMany(v => v.Errors)
                             .Select(e => e.ErrorMessage));
                   
                    //AddNotification(NotificationMessage.TitleError, response.Message, NotificationMessage.TypeError);
                    return View(model);
                }



            }
            catch (Exception e)
            {
                if (custdata != null)
                {
                    var User = _UserService.GetUserById(custdata.Id);
                    _UserService.DeleteUser(User);
                }

                return View(model);
            }
        

        }

    
   


        #endregion

        #region UserLogin


        public virtual IActionResult Login()
        {

            var model = _UserModelFactory.PrepareLoginModel();
            return View(model);
        }

        [HttpPost]
        public virtual IActionResult Login(DeVeeraApp.ViewModels.User.LoginModel model, string returnUrl, bool captchaValid)
        {

            if (ModelState.IsValid)
            {

                var loginResult = _UserRegistrationService.ValidateUserLogin(model.Email, model.Password);
                switch (loginResult)
                {
                    case UserLoginResults.Successful:
                        {
                            var User = _UserService.GetUserByEmail(model.Email);

                            _authenticationService.SignIn(User, model.RememberMe);

                            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
                            {
                                HttpContext.Session.SetInt32("CurrentUserId", _WorkContextService.CurrentUser.Id);

                                if (_WorkContextService.CurrentUser.UserRole.Name != "User")
                                {
                                    return RedirectToAction("Index", "Home");
                                }
                                else
                                {
                                    return RedirectToAction("Index", "Home");
                                }
                            }
                            return Redirect(returnUrl);
                        }
                    case UserLoginResults.UserNotExist:
                        ModelState.AddModelError("", "UserNotExist");
                        break;
                    case UserLoginResults.Deleted:
                        ModelState.AddModelError("", "Deleted");
                        break;
                    case UserLoginResults.NotActive:
                        ModelState.AddModelError("", "NotActive");
                        break;
                    case UserLoginResults.NotRegistered:
                        ModelState.AddModelError("", "NotRegistered");
                        break;
                    case UserLoginResults.LockedOut:
                        ModelState.AddModelError("", "LockedOut");
                        break;
                    case UserLoginResults.WrongPassword:
                    default:
                        ModelState.AddModelError("", "WrongCredentials");
                        break;
                }
            }

            return View(model);
        }

        public virtual IActionResult Logout()
        {
            //standard logout 
            _authenticationService.SignOut();

            //raise logged out event       
            var UserLogOut = new UserLoggedOutEvent(_WorkContextService.CurrentUser);

            if (_WorkContextService.CurrentUser != null)
            {
                _WorkContextService.CurrentUser.UserGuid = new Guid();
            }
            //delete current cookie value
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(".MarketPlaceCRM.User");
            return RedirectToAction("Login");

        }

        //public virtual IActionResult ForgotPassword()
        //{
        //    var model = new LoginModel();
        //   return View(model);
        //}

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                //fill entity from model
                var user = model.ToEntity<User>();
                UserPassword password = null;
                user.UserGuid = Guid.NewGuid();
                user.CreatedOnUtc = DateTime.UtcNow;
                user.LastActivityDateUtc = DateTime.UtcNow;
                user.UserRoleId = 3;

                user.Active = true;

                _UserService.InsertUser(user);

                // password
                if (!string.IsNullOrWhiteSpace(model.UserPassword.Password))
                {

                    password = new UserPassword
                    {
                        UserId = user.Id,
                        Password = model.UserPassword.Password,
                        CreatedOnUtc = DateTime.UtcNow,
                    };
                    _Userpasswordservice.InsertUserPassword(password);
                }
                _UserService.UpdateUser(user);
                var loginResult = _UserRegistrationService.ValidateUserLogin(model.Email, model.UserPassword.Password);
                switch (loginResult)
                {
                    case UserLoginResults.Successful:
                        {
                            var User = _UserService.GetUserByEmail(model.Email);

                            _authenticationService.SignIn(User,true);

                          
                                HttpContext.Session.SetInt32("CurrentUserId", _WorkContextService.CurrentUser.Id);

                               
                                    return RedirectToAction("Index", "Home");
                                
                          
                        }
                    case UserLoginResults.UserNotExist:
                        ModelState.AddModelError("", "UserNotExist");
                        break;
                    case UserLoginResults.Deleted:
                        ModelState.AddModelError("", "Deleted");
                        break;
                    case UserLoginResults.NotActive:
                        ModelState.AddModelError("", "NotActive");
                        break;
                    case UserLoginResults.NotRegistered:
                        ModelState.AddModelError("", "NotRegistered");
                        break;
                    case UserLoginResults.LockedOut:
                        ModelState.AddModelError("", "LockedOut");
                        break;
                    case UserLoginResults.WrongPassword:
                    default:
                        ModelState.AddModelError("", "WrongCredentials");
                        break;
                }
            }
            return View(model);
        }

        #endregion


    }
}