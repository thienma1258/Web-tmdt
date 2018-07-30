using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
    public class Store:TrackingObject
    {
        public string NameStore { get; set; }
        public string Description { get; set; }
        public string FAX { get; set; }
        public string Address { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string DefaultImage { get; set; }
        #region SEO
        public string MetaTitle { get; set; }
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
