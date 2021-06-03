﻿using CRM.Core;
using CRM.Core.Domain;
using CRM.Core.Infrastructure;
using CRM.Services;
using CRM.Services.Authentication;
using CRM.Services.Message;
using DeVeeraApp.Filters;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels;
using DeVeeraApp.ViewModels.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AuthorizeAdmin]
    public class WeeklyUpdateController : BaseController
    {

        #region fields
        private readonly IWeeklyUpdateServices _weeklyUpdateServices;
        private readonly INotificationService _notificationService;
        private readonly IVideoMasterService _videoServices;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IS3BucketService _s3BucketService;
        private readonly IImageMasterService _imageMasterService;
        #endregion

        #region ctor
        public WeeklyUpdateController(IWeeklyUpdateServices weeklyUpdateServices,
                                      IVideoMasterService videoService,
                                      IWorkContext workContext,
                                      IHttpContextAccessor httpContextAccessor,
                                      IAuthenticationService authenticationService,
                                      INotificationService notificationService,
                                      IHostingEnvironment hostingEnvironment,
                                      IS3BucketService s3BucketService,
                                      IImageMasterService imageMasterService) : base(workContext: workContext,
                                                                                  httpContextAccessor: httpContextAccessor,
                                                                                  authenticationService: authenticationService)
        {
            _weeklyUpdateServices = weeklyUpdateServices;
            _notificationService = notificationService;
            _videoServices = videoService;
            _hostingEnvironment = hostingEnvironment;
            _s3BucketService = s3BucketService;
            _imageMasterService = imageMasterService;
        }
        #endregion
        #region Utilities
        public virtual void PrepareVideo(WeeklyUpdateModel model)
        {
            //prepare available url
            model.AvailableVideo.Add(new SelectListItem { Text = "Select Video", Value = "0" });
            var AvailableVideoUrl = _videoServices.GetAllVideos();
            foreach (var url in AvailableVideoUrl)
            {
                model.AvailableVideo.Add(new SelectListItem
                {
                    Value = url.Id.ToString(),
                    Text = url.Name,
                    Selected = url.Id == model.VideoId
                });
            }
        }
        #endregion
        #region methods

        public IActionResult Create(CRM.Core.Domain.Quote type)
        {
            AddBreadcrumbs( $"{type} Video", "Create", $"/WeeklyUpdate/List?typeId={(int)type}", $"/WeeklyUpdate/Create?type={type}");
            WeeklyUpdateModel model = new WeeklyUpdateModel();
            ViewBag.QuoteType = type.ToString();
            PrepareVideo(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(WeeklyUpdateModel model)
        {
            AddBreadcrumbs($"{model.QuoteType} Video", "Create", $"/WeeklyUpdate/List?typeId={(int)model.QuoteType}", $"/WeeklyUpdate/Create?type={model.QuoteType}");

            if (ModelState.IsValid)
            {
                _weeklyUpdateServices.InActiveAllActiveQuotes((int)model.QuoteType);
                var imageUrl = UploadToAWS(model.DescriptionImage);
                
                var data = model.ToEntity<WeeklyUpdate>();
                //data.DescriptionImage = imageUrl.Result.ToString();
                data.DescriptionImage = imageUrl.Result.ToString();

                _weeklyUpdateServices.InsertWeeklyUpdate(data);
                _notificationService.SuccessNotification("Video created successfully.");
                return RedirectToAction("List", "WeeklyUpdate", new { typeId = (int)model.QuoteType });
            }
            PrepareVideo(model);
            return View(model);
        }

        public async Task<string> UploadToAWS(string fileName)
        {
            string val;

            var path = Path.Combine(_hostingEnvironment.WebRootPath + "//Files//Images", fileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                val = await _s3BucketService.UploadFileAsync(stream, path, fileName);


            }
            System.IO.File.Delete(path);
            return val;
        }

        public virtual void PrepareLevelModel(WeeklyUpdateModel model)
        {
            //prepare available url
            model.AvailableVideo.Add(new SelectListItem { Text = "Select Video", Value = "0" });
           
            //prepare available images
            var AvailableImages = _imageMasterService.GetAllImages();
            foreach (var item in AvailableImages)
            {
                model.AvailableImages.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name,
                });
            }

           
        }


        public IActionResult Edit(int id, CRM.Core.Domain.Quote type)
        {
            AddBreadcrumbs($"{type} Video", "Edit", $"/WeeklyUpdate/List?typeId={(int)type}", $"/WeeklyUpdate/Edit/{id}?type={type}");

            if (id != 0)
            {
                var data = _weeklyUpdateServices.GetWeeklyUpdateById(id);

                if (data != null)
                {
                    var model = data.ToModel<WeeklyUpdateModel>();
                    PrepareVideo(model);
                    return View(model);
                }

                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(WeeklyUpdateModel model)
        {
            AddBreadcrumbs($"{model.QuoteType} Video", "Edit", $"/WeeklyUpdate/List?typeId={(int)model.QuoteType}", $"/WeeklyUpdate/Edit/{model.Id}?type={model.QuoteType}");

            if (ModelState.IsValid)
            {
                _weeklyUpdateServices.InActiveAllActiveQuotes((int)model.QuoteType);
                
                var val = _weeklyUpdateServices.GetWeeklyUpdateById(model.Id);
                val.IsActive = model.IsActive;
                val.VideoId = model.VideoId;
                val.Title = model.Title;
                val.Subtitle = model.Subtitle;
                val.QuoteType = (CRM.Core.Domain.Quote)model.QuoteType;
                _weeklyUpdateServices.UpdateWeeklyUpdate(val);
                _notificationService.SuccessNotification("Video edited successfully.");

                return RedirectToAction("List", "WeeklyUpdate",new { typeId = (int)model.QuoteType });
            }
            PrepareVideo(model);
            return View(model);
        }

        public IActionResult List(int typeId)
        {
            AddBreadcrumbs($"{(CRM.Core.Domain.Quote)typeId} Video", "List", $"/WeeklyUpdate/List?typeId={typeId}", $"/WeeklyUpdate/List?typeId={typeId}");

            ViewBag.QuoteType = EnumDescription.GetDescription((CRM.Core.Domain.Quote)typeId);
            var model = new List<WeeklyUpdateModel>();
            var data = _weeklyUpdateServices.GetWeeklyUpdatesByQuoteType(typeId);
            if (data.Count() != 0)
            {
                model = data.ToList().ToModelList<WeeklyUpdate, WeeklyUpdateModel>(model);


            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            ResponseModel response = new ResponseModel();

            if (id != 0)
            {
                var Data = _weeklyUpdateServices.GetWeeklyUpdateById(id);
                if (Data == null)
                {
                    response.Success = false;
                    response.Message = "No user found";
                }
                _weeklyUpdateServices.DeleteWeeklyUpdate(Data);

                response.Success = true;
            }
            else
            {
                response.Success = false;
                response.Message = "Id is 0";

            }
            return Json(response);
        }

        #endregion

    }
}
