using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class SeoObject : TrackingObject
    {
        #region SEO
        public string MetaTitle { get; set; }
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
