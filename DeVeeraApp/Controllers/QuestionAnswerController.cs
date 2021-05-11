﻿using CRM.Core;
using CRM.Core.Domain.VideoModules;
using CRM.Services;
using CRM.Services.Authentication;
using CRM.Services.QuestionsAnswer;
using CRM.Services.VideoModules;
using DeVeeraApp.Utils;
using DeVeeraApp.ViewModels.QuestionAnswer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Controllers
{
    public class QuestionAnswerController : BaseController
    {
        #region fields
        private readonly ILevelServices _levelService;
        private readonly IModuleService _moduleService;
        private readonly IQuestionAnswerService _QuestionAnswerService;
        #endregion

        #region ctor
        public QuestionAnswerController(ILevelServices levelServices,
                                        IModuleService moduleService,
                                        IQuestionAnswerService questionAnswerService,
                                        IWorkContext workContext,
                                        IHttpContextAccessor httpContextAccessor,
                                        IAuthenticationService authenticationService) : base(workContext: workContext,
                                                                                             httpContextAccessor: httpContextAccessor,
                                                                                             authenticationService: authenticationService)
        {
            _levelService = levelServices;
            _moduleService = moduleService;
            _QuestionAnswerService = questionAnswerService;
        }
        #endregion

        #region Utilities
        public virtual void PrepareDropdowns(QuestionModel model)
        {
            //prepare available levels
            model.AvailableLevels.Add(new SelectListItem { Text = "Select Level", Value = "0" });
            var availableLevels = _levelService.GetAllLevels();
            foreach (var url in availableLevels)
            {
                model.AvailableLevels.Add(new SelectListItem
                {
                    Value = url.Id.ToString(),
                    Text = url.Title,
                    Selected = url.Id == model.LevelId
                });
            }

            //prepare available modules
            model.AvailableModules.Add(new SelectListItem { Text = "Select Modules", Value = "0" });
            var availableModules = _moduleService.GetAllModules();
            foreach (var url in availableModules)
            {
                model.AvailableModules.Add(new SelectListItem
                {
                    Value = url.Id.ToString(),
                    Text = url.Title,
                    Selected = url.Id == model.ModuleId
                });
            }
        }

        #endregion
        #region Methods
        public IActionResult List()
        {
            AddBreadcrumbs("Question Array", "List", "/QuestionAnswer/List", "/QuestionAnswer/List");
            var model = new QuestionModel();
            List<QuestionModel> QuestionsList = new List<QuestionModel>();
            var data = _QuestionAnswerService.GetAllQuestions().ToList();
            if (data.Count != 0)
            {
               model.QuestionsList = data.ToModelList<Questions, QuestionModel>(QuestionsList);

            }

            return View(model);
        }
        public IActionResult Create()
        {
            AddBreadcrumbs("Question Array", "Create", "/QuestionAnswer/List", "/QuestionAnswer/Create");
            QuestionModel model = new QuestionModel();
            PrepareDropdowns(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(QuestionModel model)
        {
            AddBreadcrumbs("Question Array", "Create", "/QuestionAnswer/List", "/QuestionAnswer/Create");
            if (ModelState.IsValid)
            {
                var data = model.ToEntity<Questions>();
                data.CreatedOn = DateTime.UtcNow;

                _QuestionAnswerService.InsertQuestion(data);

                return RedirectToAction("Index", "Module",new {id=model.ModuleId });
            }
            PrepareDropdowns(model);
            return View(model);
        }

        [HttpGet]
        public IActionResult GetModuleByLevelId(int Id, int SelectedId)
        {
            List<SelectListItem> Modules = new List<SelectListItem>();
            //modules
            var modules = _moduleService.GetModulesByLevelId(Id).ToList();
            Modules.Add(new SelectListItem { Text = "Select Module", Value = null });
            if (modules.Any())
            {              
                foreach (var s in modules)
                {
                    Modules.Add(new SelectListItem { Text = s.Title, Value = s.Id.ToString(), Selected = (s.Id == SelectedId) });
                }
            }

            return Json(Modules);
        }

        #endregion
    }
}