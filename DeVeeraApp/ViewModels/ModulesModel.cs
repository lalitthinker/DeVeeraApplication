﻿using CRM.Core.Domain;
using CRM.Core.Domain.VideoModules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.ViewModels
{
    public class ModulesModel : BaseEntityModel
    {
        public ModulesModel()
        {
            QuestionsList = new List<Questions>();
        }
        public string Title { get; set; }
        public int LevelId { get; set; }
        public string VideoURL { get; set; }
        public string FullDescription { get; set; }
        public virtual Level Level { get; set; }

        [NotMapped]
        public string DiaryText { get; set; }

        [NotMapped]
        public string DiaryLatestUpdateDate { get; set; }

        [NotMapped]
        public List<Questions> QuestionsList { get; set; }
    }
}
