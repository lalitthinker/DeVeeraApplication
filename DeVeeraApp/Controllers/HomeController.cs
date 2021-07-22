﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeVeeraApp.ViewModels.User;
using DeVeeraApp.Utils;
using CRM.Services.Users;
using CRM.Services;
using DeVeeraApp.ViewModels;
using CRM.Services.DashboardQuotes;
using CRM.Core;
using Microsoft.AspNetCore.Http;
using CRM.Services.Authentication;
using CRM.Services.DashboardMenu;

using Microsoft.AspNetCore.Localization;
using CRM.Services.Layoutsetup;
using CRM.Core.ViewModels;

namespace DeVeeraApp.Controllers
{

    public class HomeController : BaseController
    {
        #region fields

        private readonly ILogger<HomeController> _logger;
        private readonly ILevelServices _levelServices;
        private readonly IWeeklyUpdateServices _weeklyUpdateServices;
        private readonly IDashboardQuoteService _dashboardQuoteService;
        private readonly IDashboardMenuService _dashboardMenuService;
        private readonly IUserService _UserService;
        private readonly IWorkContext _workContext;
        private readonly IFeelGoodStoryServices _feelGoodStoryServices;
        private readonly IImageMasterService _imageMasterService;
        private readonly IVideoMasterService _videoMasterService;
        private readonly IS3BucketService _s3BucketService;
        private readonly ILanguageService _languageService;
        private readonly ILayoutSetupService _LayoutSetupService;
        private readonly ILocalStringResourcesServices _localStringResourcesServices;
        #endregion


        #region ctor
        public HomeController(ILogger<HomeController> logger,
                              ILevelServices levelServices,
                              IWeeklyUpdateServices weeklyUpdateServices,
                              IDashboardQuoteService dashboardQuoteService,
                              IDashboardMenuService dashboardMenuService,
                              IWorkContext workContext,
                              IHttpContextAccessor httpContextAccessor,
                              IAuthenticationService authenticationService,
                              IFeelGoodStoryServices feelGoodStoryServices,
                              IImageMasterService imageMasterService,
                              IVideoMasterService videoMasterService,
                              IS3BucketService s3BucketService,
                              ILanguageService languageService,
                              IUserService userService,
                               ILayoutSetupService layoutSetupService,
                               ILocalStringResourcesServices localStringResourcesServices
                              ) : base(workContext: workContext,
                                                                                  httpContextAccessor: httpContextAccessor,
                                                                                  authenticationService: authenticationService)
        {
            _logger = logger;
            _levelServices = levelServices;
            _weeklyUpdateServices = weeklyUpdateServices;
            _dashboardQuoteService = dashboardQuoteService;
            _dashboardMenuService = dashboardMenuService;
            _UserService = userService;
            _workContext = workContext;
            _feelGoodStoryServices = feelGoodStoryServices;
            _imageMasterService = imageMasterService;
            _videoMasterService = videoMasterService;
            _s3BucketService = s3BucketService;
            _languageService = languageService;
            _LayoutSetupService = layoutSetupService;
            _localStringResourcesServices = localStringResourcesServices;
        }

        #endregion

        #region Utilities



        #endregion

        #region Method
        public IActionResult Index()
        {
            var random = new Random();
            var model = new UserModel();

            var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType((int)ViewModels.Quote.Landing);
            if (data != null) 
            {
                model.LandingPageModel.WeeklyUpdate = data.ToModel<WeeklyUpdateModel>();
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderOneDescription);
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderOneTitle);
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderTwoTitle);
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderTwoDescription);
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderThreeTitle);
                _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.SliderThreeDescription);

                var quoteList = _dashboardQuoteService.GetAllDashboardQuotes().Where(a => a.IsRandom == true).ToList();
                if (quoteList != null && quoteList.Count > 0 && data.IsRandom == true)
                {
                    int index = random.Next(quoteList.Count);
                    model.LandingPageModel.WeeklyUpdate.LandingQuote = quoteList[index].Title + " -- " + quoteList[index].Author;
                    _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.LandingQuote);
                    _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.Subtitle);
                    _localStringResourcesServices.GetLocalStringResourceByResourceName(model.LandingPageModel.WeeklyUpdate.Title);
                }

                ViewBag.VideoUrl = data?.Video?.VideoUrl;

                model.LandingPageModel.SliderOneImageUrl = data.SliderOneImageId > 0 ? _imageMasterService.GetImageById(data.SliderOneImageId)?.ImageUrl : null;
                model.LandingPageModel.SliderTwoImageUrl = data.SliderTwoImageId > 0 ? _imageMasterService.GetImageById(data.SliderTwoImageId)?.ImageUrl : null;
                model.LandingPageModel.SliderThreeImageUrl = data.SliderThreeImageId > 0 ? _imageMasterService.GetImageById(data.SliderThreeImageId)?.ImageUrl : null;
                model.LandingPageModel.DescriptionImageUrl = data.DescriptionImageId > 0 ? _imageMasterService.GetImageById(data.DescriptionImageId)?.ImageUrl : null;
              
            }
            return View(model);
        }

        
        public IActionResult AskHappynessLevel()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult AskHappynessLevel(HappynessLevelModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.HappynessLevelTypeId > (int)HappynessLevelType.LevelSix)
                {
                    var data = _levelServices.GetAllLevels().Where(l => l.Level_Emotion_Mappings.Where(a => a.Emotion?.EmotionName == "Happy").Count() > 0 && l.Active == true).FirstOrDefault();
                    if (data != null)
                    {
                        return RedirectToAction("Index", "Lesson", new { id = data.Id });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                else
                {
                    return RedirectToAction("Create", "Diary");
                }
            }
            else
            {
                return View(model);
            }

        }


        [HttpPost]
        public IActionResult CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });

            return RedirectToAction(nameof(Index));
        }

      
        public IActionResult ExistingUser(int QuoteType,DateTime LastLoginDateUtc)
        {
            var random = new Random();
            ViewBag.LastLoginDateUtc = LastLoginDateUtc;

            var currentUser = _UserService.GetUserById(_workContext.CurrentUser.Id);
            var currentLevel = currentUser?.LastLevel > 0?_levelServices.GetLevelById((int)currentUser.LastLevel)?.LevelNo:null;
            if (QuoteType !=0)
            {
                var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType(QuoteType);
                var model = data?.ToModel<WeeklyUpdateModel>();
                if (model.BodyImageId != 0 && model.BannerImageId != 0)
                {
                    var bannerImageData = _imageMasterService.GetImageById(model.BannerImageId);
                    var bodyImageData = _imageMasterService.GetImageById(model.BodyImageId);

                    if (bannerImageData != null)
                    {
                        model.BannerImageURL = bannerImageData.ImageUrl;
                    }
                    if (bodyImageData != null)
                    {
                        model.BodyImageURL = bodyImageData.ImageUrl;
                    }
                }
                if (model != null)
                {
                    model.VideoUrl = _videoMasterService.GetVideoById((int)data?.Video?.Id).VideoUrl;

                    model.LastLevel = (currentLevel > _levelServices.GetAllLevels().Max(a => a.LevelNo)) ? (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault().LevelNo : currentLevel ?? (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault().LevelNo;

                    model.FirstLevel = (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault()?.LevelNo;

                }

                return View(model);
            }
            else
            {
                var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType((int)ViewModels.Quote.Login);
                var model = data?.ToModel<WeeklyUpdateModel>();

                if (model.BodyImageId != 0 && model.BannerImageId != 0)
                {
                    var bannerImageData = _imageMasterService.GetImageById(model.BannerImageId);
                    var bodyImageData = _imageMasterService.GetImageById(model.BodyImageId);

                    if (bannerImageData != null)
                    {
                        model.BannerImageURL = bannerImageData.ImageUrl;
                    }
                    if (bodyImageData != null)
                    {
                        model.BodyImageURL = bodyImageData.ImageUrl;
                    }
                }
                if (model != null)
                {
                    model.VideoUrl = _videoMasterService.GetVideoById((int)data?.Video?.Id).VideoUrl;

                    model.LastLevel = (currentLevel > _levelServices.GetAllLevels().Max(a => a.LevelNo)) ? (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault().LevelNo : currentLevel ?? (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault().LevelNo;

                    model.FirstLevel = (int)_levelServices.GetAllLevels().OrderBy(a => a.LevelNo).FirstOrDefault()?.LevelNo;

                }

                return View(model);
            }
            

           

            //var quoteList = _dashboardQuoteService.GetAllDashboardQuotes().Where(a => a.IsRandom == true).ToList();
            //if (quoteList != null && quoteList.Count > 0 && data.IsRandom == true)
            //{
            //    int index = random.Next(quoteList.Count);
            //    model.Title = quoteList[index].Title + " -- " + quoteList[index].Author;
            //}

          
        }

        public IActionResult NewUser(int QuoteType)
        {
            var random = new Random();
            var currentUser = _UserService.GetUserById(_workContext.CurrentUser.Id);

            var data = _weeklyUpdateServices.GetWeeklyUpdateByQuoteType((int)ViewModels.Quote.Registration);

            var model = data?.ToModel<WeeklyUpdateModel>();
            var quoteList = _dashboardQuoteService.GetAllDashboardQuotes().Where(a => a.IsRandom == true).ToList();

            //if (quoteList != null && quoteList.Count > 0 && data.IsRandom==true)
            //{
            //    int index = random.Next(quoteList.Count);
            //    model.Title = quoteList[index].Title + " -- " + quoteList[index].Author;
            //}

            if (model.BodyImageId != 0 && model.BannerImageId != 0)
            {
                var bannerImageData = _imageMasterService.GetImageById(model.BannerImageId);
                var bodyImageData = _imageMasterService.GetImageById(model.BodyImageId);

                if (bannerImageData != null)
                {
                    model.BannerImageURL = bannerImageData.ImageUrl;
                }
                if (bodyImageData != null)
                {
                    model.BodyImageURL = bodyImageData.ImageUrl;
                }
            }
            if (model != null)
            {
                model.VideoUrl = data?.Video?.VideoUrl;
                var firstLevel = _levelServices.GetAllLevels().OrderBy(a=>a.LevelNo).FirstOrDefault();
                if (firstLevel != null)
                {
                    model.LastLevel = (int)firstLevel.LevelNo;
                }
                currentUser.LastLevel = firstLevel.Id;
                _UserService.UpdateUser(currentUser);

            }
            _localStringResourcesServices.GetLocalStringResourceByResourceName(model.Subtitle);
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
       
        public IActionResult WeeklyInspiringQuotes(DataSourceRequest command)
        {
            AddBreadcrumbs("Home", "WeeklyInspiringQuotes", "/Home/WeeklyInspiringQuotes", "/Home/WeeklyInspiringQuotes");
            DashboardListQuote model = new DashboardListQuote();

          var WeeklyQuoteData = _dashboardQuoteService.GetAllDashboardQuotes().Where(q => q.IsWeeklyInspiringQuotes == true).ToList();
           // var data = _LayoutSetupService.GetAllLayoutSetups().FirstOrDefault();
            command.PageSize = (command.PageSize == 0) ? 5: command.PageSize;
            var list = _dashboardQuoteService.GetAllDashboardQuoteSp(page_size: command.PageSize, page_num: command.Page, GetAll: command.GetAll, SortBy: "");
            model.DashboardQuoteListPaged = list.FirstOrDefault() != null ? list.GetPaged(command.Page, command.PageSize, list.FirstOrDefault().TotalRecords) : new PagedResult<DashBoardQuoteViewModel>();
           
            return View(model);
        }
      
        public IActionResult NewVideos(DataSourceRequest command)
        {
            AddBreadcrumbs("Home", "NewVideos", "/Home/NewVideos", "/Home/NewVideos");
            VideoListModel model = new VideoListModel();
            var data = _LayoutSetupService.GetAllLayoutSetups().FirstOrDefault();
          
            command.PageSize = (command.PageSize == 0) ? 12 : command.PageSize;
            var list = _videoMasterService.GetAllVideoSp(page_size: command.PageSize,page_num: command.Page,  GetAll: command.GetAll, SortBy: "");
            model.VideoListPaged = list.FirstOrDefault() != null ? list.GetPaged(command.Page, command.PageSize, list.FirstOrDefault().TotalRecords) : new PagedResult<VideoViewModel>();
            model.Video.Link_2_bannerImage = data?.Link_2_BannerImageId > 0 ? _imageMasterService.GetImageById(data.Link_2_BannerImageId)?.ImageUrl : null;
            model.Video.Link_2_Title = data.Link_2;
            return View(model);
        }    
      
        public IActionResult FeelGoodStories(DataSourceRequest command)
        {
            AddBreadcrumbs("Home", "FeelGoodStories", "/Home/FeelGoodStories", "/Home/FeelGoodStories");
          //  var data = _feelGoodStoryServices.GetAllFeelGoodStorys();

            FeelGoodListModel model = new FeelGoodListModel ();
           command.PageSize = (command.PageSize == 0) ? 10 : command.PageSize;
            var list = _feelGoodStoryServices.GetAllFeelGoodStoriesSp(page_size: command.PageSize, page_num: command.Page, GetAll: command.GetAll, SortBy: "",ImageId:0);
           
            model.FeelGoodListPaged = list.FirstOrDefault() != null ? list.GetPaged(command.Page, command.PageSize, list.FirstOrDefault().TotalRecords) : new PagedResult<FeelGoodViewModel>();
            return View(model);
        }
   

        #endregion
    }
}
