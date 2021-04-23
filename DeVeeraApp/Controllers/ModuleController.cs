﻿using CRM.Core;
using CRM.Core.Domain.VideoModules;
using CRM.Services;
using CRM.Services.Users;
using CRM.Services.VideoModules;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;
        private readonly IWorkContext _workContext;
        private readonly IUserService _userService;
        private readonly IDiaryMasterService _diaryMasterService;

        public ModuleController(IModuleService moduleService,
                                IWorkContext workContext,
                                IUserService userService,
                                IDiaryMasterService diaryMasterService)
        {
            _moduleService = moduleService;
            _workContext = workContext;
            _userService = userService;
            _diaryMasterService = diaryMasterService;
        }

        #region methods

        public IActionResult Index(int id, int srno, int levelSrno)
        {
            ViewBag.SrNo = srno;
            ViewBag.LevelSrNo = levelSrno;
            var data = _moduleService.GetModuleById(id);
            ViewBag.TotalModules = _moduleService.GetAllModules().Where(a=>a.LevelId == data.LevelId).Count();
           
            var moduleData = data.ToModel<ModulesModel>();
            Diary diary = new Diary();
            if (_workContext.CurrentUser.UserRole.Name == "Admin")
            {
                diary = _diaryMasterService.GetAllDiarys().OrderByDescending(a => a.Id).FirstOrDefault();
            }
            else
            {
                diary = _diaryMasterService.GetAllDiarys().Where(a => a.UserId == _workContext.CurrentUser.Id).OrderByDescending(a => a.Id).FirstOrDefault();

            }
            moduleData.DiaryText = diary != null ? diary.Comment : "";
            moduleData.DiaryLatestUpdateDate = diary != null ? diary.CreatedOn.ToShortDateString() : "";
            return View(moduleData);
        }



        public IActionResult Previous(int id, int srno, int levelSrno)
        {

            var data = _moduleService.GetAllModules().OrderByDescending(a => a.Id).Where(a => a.Id < id).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("Index", new { id = data.Id, srno = srno - 1, levelsrno = levelSrno });
            }
            return RedirectToAction("Index", new { id = id, srno = srno - 1, levelsrno = levelSrno });
        }

        public IActionResult Next(int id, int srno, int levelSrno)
        {
            var currentUser = _userService.GetUserById(_workContext.CurrentUser.Id);
                ViewBag.SrNo = srno;
                var data = _moduleService.GetAllModules().Where(a => a.Id > id).FirstOrDefault();
                if (data != null)
                {
                    return RedirectToAction("Index", new { id = data.Id, srno = srno + 1, levelsrno = levelSrno });
                }
                return RedirectToAction("Index", new { id = id, srno = srno + 1, levelsrno = levelSrno });
        }

        #endregion
    }
}
