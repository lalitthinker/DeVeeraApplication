﻿using CRM.Core;
using CRM.Core.Domain;

using CRM.Core.Domain.VideoModules;
using CRM.Services;
using CRM.Services.Message;
using CRM.Services.VideoModules;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels;
using DeVeeraApp.ViewModels.Common;
using DeVeeraApp.ViewModels.Diaries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Controllers
{
    public class DiaryController : Controller
    {
        #region field

        private readonly INotificationService _notificationService;
        private readonly IDiaryMasterService _DiaryMasterService;
        private readonly IWorkContext _workContext;
        private readonly ILevelServices _levelServices;
        private readonly IModuleService _moduleService;

        #endregion


        #region ctor

        public DiaryController(INotificationService notificationService,
                       IDiaryMasterService DiaryMasterService,
                       IWorkContext workContext,
                       ILevelServices levelServices,
                       IModuleService moduleService)
        {
            _notificationService = notificationService;
            _DiaryMasterService = DiaryMasterService;
            _workContext = workContext;
            _levelServices = levelServices;
            _moduleService = moduleService;
        }

        #endregion


        #region Method

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create(int levelid, int moduleid)
        {
            DiaryModel model = new DiaryModel();
            var levelCount = _levelServices.GetAllLevels().Where(a => a.Id <= levelid).Count();
            var module = _moduleService.GetModuleById(moduleid);
            if (module != null)
            {
                var moduleCount = _moduleService.GetAllModules().Where(a => a.Id <= module.Id && a.LevelId == module.LevelId).Count();
                model.Module = "Module " + moduleCount;
            }

            model.Level = "Level " + levelCount;
            model.ModuleId = moduleid;
            model.LevelId = levelid;


            return View(model);

        }

        [HttpPost]
        public IActionResult Create(DiaryModel model)
        {
            if (ModelState.IsValid)
            {
                var data = model.ToEntity<Diary>();
                data.UserId = _workContext.CurrentUser.Id;
                data.CreatedOn = DateTime.UtcNow;
                _DiaryMasterService.InsertDiary(data);
                _notificationService.SuccessNotification("Diary added successfully.");
                return RedirectToAction("List");
            }
            return View();

        }

        public IActionResult Edit(int id)
        {
            if (id != 0)
            {
                var data = _DiaryMasterService.GetDiaryById(id);
                if (data != null)
                {
                    var model = data.ToModel<DiaryModel>();

                    var levelCount = _levelServices.GetAllLevels().Where(a => a.Id <= model.LevelId).Count();
                    var module = _moduleService.GetModuleById((int)model.ModuleId);
                    if (module != null)
                    {
                        var moduleCount = _moduleService.GetAllModules().Where(a => a.Id <= module.Id && a.LevelId == module.LevelId).Count();
                        model.Module = "Module " + moduleCount;
                    }

                    model.Level = "Level " + levelCount;

                

                    return View(model);
                }
            }
            return RedirectToAction("List");

        }

        [HttpPost]
        public IActionResult Edit(DiaryModel model)
        {

            if (ModelState.IsValid)
            {
                var DiaryData = _DiaryMasterService.GetDiaryById(model.Id);
                DiaryData.Comment = model.Comment;
                _DiaryMasterService.UpdateDiary(DiaryData);
                _notificationService.SuccessNotification("Diary url updated successfully.");
                return RedirectToAction("List");
            }
            return View();

        }

        public IActionResult List()
        {
            List<DiaryModel> DiaryList = new List<DiaryModel>();
            var AllDiaries = _DiaryMasterService.GetAllDiarys();
            if (_workContext.CurrentUser.UserRole.Name == "Admin")
            {

                foreach(var item in AllDiaries)
                {
                    DiaryModel diaryModel = new DiaryModel();

                    diaryModel.Id = item.Id;
                    diaryModel.Comment = item.Comment;
                    diaryModel.CreatedOn = item.CreatedOn;
                    var levelCount = _levelServices.GetAllLevels().Where(a => a.Id <= item.LevelId).Count();
                    var module = _moduleService.GetModuleById((int)item.ModuleId);
                    if (module != null)
                    {
                        var moduleCount = _moduleService.GetAllModules().Where(a => a.Id <= module.Id && a.LevelId == module.LevelId).Count();
                        diaryModel.Module = "Module " + moduleCount;
                    }

                    diaryModel.Level = "Level " + levelCount;

                    diaryModel.ModuleId = item.ModuleId;
                    diaryModel.LevelId = item.LevelId;
                    DiaryList.Add(diaryModel);

                }
                
            }
            else
            {
                foreach (var item in AllDiaries.Where(a => a.UserId == _workContext.CurrentUser.Id))
                {
                    DiaryModel diaryModel = new DiaryModel();

                    diaryModel.Id = item.Id;
                    diaryModel.Comment = item.Comment;
                    diaryModel.CreatedOn = item.CreatedOn;
                    var levelCount = _levelServices.GetAllLevels().Where(a => a.Id <= item.LevelId).Count();
                    var module = _moduleService.GetModuleById((int)item.ModuleId);
                    if (module != null)
                    {
                        var moduleCount = _moduleService.GetAllModules().Where(a => a.Id <= module.Id && a.LevelId == module.LevelId).Count();
                        diaryModel.Module = "Module " + moduleCount;
                    }

                    diaryModel.Level = "Level " + levelCount;

                    diaryModel.ModuleId = item.ModuleId;
                    diaryModel.LevelId = item.LevelId;
                    DiaryList.Add(diaryModel);

                }
             
            }

            return View(DiaryList);

        }

        public IActionResult Delete(int DiaryId)
        {
            ResponseModel response = new ResponseModel();

            if (DiaryId != 0)
            {
                var DiaryData = _DiaryMasterService.GetDiaryById(DiaryId);
                if (DiaryData == null)
                {
                    response.Success = false;
                    response.Message = "No Diary found";
                }
                _DiaryMasterService.DeleteDiary(DiaryData);

                response.Success = true;
            }
            else
            {
                response.Success = false;
                response.Message = "DiaryId is 0";

            }
            return Json(response);
        }
        #endregion


    }
}
