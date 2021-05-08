﻿using CRM.Core.Domain;
using CRM.Services;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels;
using DeVeeraApp.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Controllers
{
    public class FeelGoodStoryController : Controller
    {

        #region fields
        private readonly IFeelGoodStoryServices _feelGoodStoryServices;
        private readonly IImageMasterService _imageMasterService;
        #endregion

        #region ctor

        public FeelGoodStoryController(IFeelGoodStoryServices feelGoodStoryServices,
                                       IImageMasterService imageMasterService)
        {
            _feelGoodStoryServices = feelGoodStoryServices;
            _imageMasterService = imageMasterService;
        }
        #endregion

        #region Utilities

        public virtual void PrepareImages(FeelGoodStoryModel model)
        {
            //prepare available url
            model.AvailableImages.Add(new SelectListItem { Text = "Select Video", Value = "0" });
            var AvailableVideoUrl = _imageMasterService.GetAllImages();
            foreach (var item in AvailableVideoUrl)
            {
                model.AvailableImages.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name
                });
            }
        }


        #endregion




        #region Methods
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            FeelGoodStoryModel model = new FeelGoodStoryModel();
            PrepareImages(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(FeelGoodStoryModel model)
        {
            if (ModelState.IsValid)
            {
                model.ImageId = (model.ImageId == 0) ? model.ImageId = null : model.ImageId;
                var data = new FeelGoodStory();
                data.Author = model.Author;
                data.Title = model.Title;
                data.Story = model.Story;
                data.ImageId = model.ImageId;

                _feelGoodStoryServices.InsertFeelGoodStory(data);
                return RedirectToAction("List");
            }
            PrepareImages(model);

            return View();
        }


        public IActionResult Edit(int Id)
        {
            var data = _feelGoodStoryServices.GetFeelGoodStoryById(Id);
            var model = data.ToModel<FeelGoodStoryModel>();
            PrepareImages(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(FeelGoodStoryModel model)
        {
            if (ModelState.IsValid)
            {
                model.ImageId = (model.ImageId == 0) ? model.ImageId = null : model.ImageId;

                var data = _feelGoodStoryServices.GetFeelGoodStoryById(model.Id);
                data.Author = model.Author;
                data.Title = model.Title;
                data.Story = model.Story;
                data.ImageId = model.ImageId;

                _feelGoodStoryServices.UpdateFeelGoodStory(data);
                return RedirectToAction("List");
            }
            PrepareImages(model);

            return View(model);
        }


        public IActionResult List()
        {
            var model = new List<FeelGoodStoryModel>();
            var data = _feelGoodStoryServices.GetAllFeelGoodStorys();

            if(data.Count != 0)
            {
                foreach(var item in data)
                {
                    model.Add(item.ToModel<FeelGoodStoryModel>());
                }

                return View(model);
            }

            return View();
        }

        public IActionResult Delete(int storyId)
        {
            ResponseModel response = new ResponseModel();

            if (storyId != 0)
            {
                var storyData = _feelGoodStoryServices.GetFeelGoodStoryById(storyId);
                if (storyData == null)
                {
                    response.Success = false;
                    response.Message = "No video found";
                }
                _feelGoodStoryServices.DeleteFeelGoodStory(storyData);

                response.Success = true;
            }
            else
            {
                response.Success = false;
                response.Message = "videoId is 0";

            }
            return Json(response);
        }


        #endregion
    }
}