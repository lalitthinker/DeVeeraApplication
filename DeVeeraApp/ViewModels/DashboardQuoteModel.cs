﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.ViewModels
{
    public class DashboardQuoteModel:BaseEntityModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public bool IsActive { get; set; } 
    }
}
