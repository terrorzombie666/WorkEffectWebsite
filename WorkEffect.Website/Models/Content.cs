﻿using System.Data.Linq.Mapping;

namespace WorkEffect.Website.Models
{
    public class Content : BaseEntity
    {
        public string Text { get; set; }
        
        public string Image { get; set; }
        
        public string Layout { get; set; }

        public virtual Section Section { get; set; }
        public int SectionId { get; set; }
    }
}