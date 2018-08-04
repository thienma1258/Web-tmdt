using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model.PM
{
    public class Voucher:TrackingObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UniqueCode { get; set; }
        public int DiscoutRate { get; set; }
        public DateTime ExperiedTime { get; set; }
    }
}
