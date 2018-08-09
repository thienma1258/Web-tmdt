using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.TransportType
{
    public class AddTransportTypePrice
    {
        [Required]
        public string IdTransport { get; set; }
        [Required]
        public string DistrictID { get; set; }
        [Required]
        public   decimal Price { get; set; }
    }
}
