using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class Brand:TrackingObject
    {
     
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
      
    
        #region SEO
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
