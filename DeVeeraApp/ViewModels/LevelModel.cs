﻿using CRM.Core.Domain;
using CRM.Core.Domain.VideoModules;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.ViewModels
{
    public class LevelModel : BaseEntityModel
    {
        public LevelModel()
        {
            Modules = new Modules();
            this.AvailableVideo = new List<SelectListItem>();
        }
        public int? VideoId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Subtitle { get; set; }
     
        public string Quote { get; set; }
       
        public string VideoUrl { get; set; }
        public string VideoName { get; set; }

        public string FullDescription { get; set; }
        public Modules Modules { get; set; }
        public Video Video { get; set; }

        public IList<Modules>ModuleList { get; set; }
        public IList<SelectListItem> AvailableVideo { get; set; }


        [NotMapped]
        public int srno { get; set; }


        [NotMapped]
        public string DiaryText { get; set; }

        [NotMapped]
        public string DiaryLatestUpdateDate { get; set; }

    }
}
