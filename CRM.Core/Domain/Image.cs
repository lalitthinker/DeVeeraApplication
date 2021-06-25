﻿using System;

namespace CRM.Core.Domain
{
    public class Image : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Key { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }


    }
}
