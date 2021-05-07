﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeVeeraApp.Models;
using DeVeeraApp.Filters;
using CRM.Core.Domain.Users;
using DeVeeraApp.ViewModels.User;
using DeVeeraApp.Utils;
using CRM.Services.Users;
using CRM.Services;
using DeVeeraApp.ViewModels;
using CRM.Core.Domain;
using CRM.Services.DashboardQuotes;
using CRM.Core;
using Microsoft.AspNetCore.Http;
using CRM.Services.Authentication;

namespace DeVeeraApp.Controllers
{
    [AuthorizeAdmin]
    public class HomeController : BaseController
    {
        #region fields

        private readonly ILogger<HomeController> _logger;
        private readonly ILevelServices _levelServices;
        private readonly IWeeklyUpdateServices _weeklyUpdateServices;
        private readonly IDashboardQuoteService _dashboardQuoteService;
        private readonly IUserService _UserService;
        private readonly IWorkContext _workContext;

        #endregion


        #region ctor
        public HomeController(ILogger<HomeController> logger,
                              ILevelServices levelServices,
                              IWeeklyUpdateServices weeklyUpdateServices,
                              IDashboardQuoteService dashboardQuoteService,
                              IWorkContext workContext,
                              IHttpContextAccessor httpContextAccessor,
                              IAuthenticationService authenticationService,
                              IUserService userService                             
                              ) :base(workContext: workContext,
                                                                                  httpContextAccessor: httpContextAccessor,
                                                                                  authenticationService: authenticationService)
        {
            _logger = logger;
            _levelServices = levelServices;
            _weeklyUpdateServices = weeklyUpdateServices;
            _dashboardQuoteService = dashboardQuoteService;
            _UserService = userService;
            _workContext = workContext;

        }

        #endregion

        #region Method
        public IActionResult Index()
        {
            AddBreadcrumbs("Application", "Dashboard","/Home/Index", "/Home/Index");

            var currentUser = _UserService.GetUserById(_workContext.CurrentUser.Id);
            var model = new DashboardQuoteModel();
            var quote = _dashboardQuoteService.GetAllDashboardQutoes().Where(a => a.IsDashboardQuote == true).FirstOrDefault();
            model.Title = quote?.Title;
            model.Author = quote?.Author;

            var data = _levelServices.GetAllLevels();
            int lastlevel = data.LastOrDefault().Id;
            if (data.Count() != 0)
            {
                if(!(_workContext.CurrentUser.UserRole.Name == "Admin"))
                {
                    var LevelOne = data.FirstOrDefault();
                    var lastLevelForNewUser = data.Where(a => a.Id == LevelOne.Id).FirstOrDefault();
                    var lastLevelForOldUser = data.Where(a => a.Id == currentUser.LastLevel).FirstOrDefault();

                    lastlevel = (currentUser.LastLevel == null || currentUser.LastLevel == 0) ? lastlevel = lastLevelForNewUser.Id : lastlevel = lastLevelForOldUser.Id;

                }


                foreach (var item in data)
                {

                    model.VideoModelList.Add(item.ToModel<LevelModel>());
                    if(item.Id == lastlevel)
                    {
                        break;
                    }

                }
                return View(model);
            }
            return View();
        }

        public IActionResult ExistingUser(int QuoteType)
        {
            var level = new Level();
            var currentUser = _UserService.GetUserById(_workContext.CurrentUser.Id);
            
               var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType((int)ViewModels.Quote.Login);

                var model = data.ToModel<WeeklyUpdateModel>();
                model.VideoUrl = data?.Video?.VideoUrl;
                if(currentUser.LastLevel!=null)
                level = _levelServices.GetLevelById((int)currentUser.LastLevel);
            
            var firstlevel = _levelServices.GetAllLevels().FirstOrDefault().Id;
            model.LastLevel = (currentUser.LastLevel == null || currentUser.LastLevel  == 0)? firstlevel : (level!= null? (int)currentUser.LastLevel : firstlevel);


            var lastLevel = _levelServices.GetAllLevels().Where(a => a.Id <= model.LastLevel);

            if (lastLevel != null)
            {
                ViewBag.SrNo = lastLevel.Count();
            }
            else
            {
                ViewBag.SrNo = 1;
            }

            return View(model);
        }

        public IActionResult NewUser(int QuoteType)
        {
            var currentUser = _UserService.GetUserById(_workContext.CurrentUser.Id);
       
                var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType((int)ViewModels.Quote.Registration);
            
                var model = data.ToModel<WeeklyUpdateModel>();
            model.VideoUrl = data?.Video?.VideoUrl;
            var firstLevel = _levelServices.GetAllLevels().FirstOrDefault();
                if (firstLevel != null)
                    model.LastLevel = firstLevel.Id;
                ViewBag.SrNo = 1;
                return View(model);
          
    

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }
        public IActionResult UnderDevelopment()
        {
            return View();
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


        #endregion
    }
}
