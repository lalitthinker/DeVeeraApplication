﻿using CRM.Core.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeVeeraApp.ViewModels.Emotions
{
    public class EmotionModel:BaseEntityModel
    {
        public EmotionModel()
        {
            EmotionList = new List<EmotionModel>();
            AvailableImages = new List<SelectListItem>();
            AvailableVideo = new List<SelectListItem>();
            ImagesList = new List<Image>();
        }

        [Required]
        public int? EmotionNo { get; set; }

        [Required]
        public int VideoId { get; set; }

        [Required]
        public int ContentImageId { get; set; }

        [Required]
        public int BannerImageId { get; set; }

        [Required]
        public int ThumbnailImageId { get; set; }

        [Required]
        public string EmotionName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public string Quote { get; set; }

        [Required]
        public string Description { get; set; }

        public string ContentImageUrl { get; set; }
        public string BannerImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public bool Deleted { get; set; }
        public virtual Video Video { get; set; }
        public IList<SelectListItem> AvailableVideo { get; set; }
        public IList<SelectListItem> AvailableImages { get; set; }
        public List<EmotionModel> EmotionList { get; set; }
        public List<Image> ImagesList { get; set; }
    }
}
