﻿using CRM.Services;
using DeVeeraApp.ViewModels;
using DeVeeraApp.ViewModels.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.Areas.Admin.ViewComponents
{
    public class AdminMenuViewComponent : ViewComponent
    {
       

        public AdminMenuViewComponent()
        {
           
        }


        public IViewComponentResult Invoke()
        {

        
            return View();
        }

    }
}
