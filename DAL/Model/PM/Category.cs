using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public class Category:TrackingObject
    {
        public string Name { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public string Description { get; set; }
        #region SEO
        public string MetaTitle { get; set; }
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
