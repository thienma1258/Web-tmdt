using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
    public class Voucher:TrackingObject
    {
        public string UniqueCode { get; set; }
        public int DiscoutRate { get; set; }
        public DateTime ExperiedTime { get; set; }
    }
}
