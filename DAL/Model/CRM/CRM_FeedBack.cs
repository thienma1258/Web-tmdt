using Common.Enum.CRM;
using DAL.Model.CM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.CRM
{
    public class CRM_FeedBack
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public CM_Customer Customer { get; set; }
        public string CustomerID { get; set; }

        public string FeedBack { get; set; }
        public FeedBackEnum State { get; set; }
        public string ReviewUser { get; set; }
        public DateTime ReviewDate { get; set; }
        
    }
}
