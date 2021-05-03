﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.ViewModels
{
    public class ImageModel : BaseEntityModel
    {
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Key { get; set; }
        public string FileName { get; set; }
    }
}