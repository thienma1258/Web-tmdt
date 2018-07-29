using DAL.Enum.PM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class SubGroup:TrackingObject
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public string Description { get; set; } = string.Empty;
        
        public TypeSexEnum TypeSex { get; set; } = TypeSexEnum.All;
        public MainGroup MainGroup { get; set; }
        #region SEO
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
