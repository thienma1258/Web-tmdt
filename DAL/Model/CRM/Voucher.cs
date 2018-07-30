using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.CRM
{
    public class Voucher:TrackingObject
    {
        public string UniqueCode { get; set; }
        public int DiscoutRate { get; set; }
        public DateTime ExperiedTime { get; set; }
    }
}
