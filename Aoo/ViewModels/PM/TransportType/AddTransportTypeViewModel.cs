using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.TransportType
{
    public class AddTransportTypeViewModel
    {
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
    }
}
