using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace DAL.Model.PM
{
    public class Store:SeoObject
    {
        
        public string NameStore { get; set; }
        public string Description { get; set; }
        public string FAX { get; set; }
        public string Address { get; set; }
        public District District { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string DefaultImage { get; set; }
      
    }
}
