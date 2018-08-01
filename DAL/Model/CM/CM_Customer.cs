using Common.Enum.SM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.CM
{
    public class CM_Customer:TrackingObject
    {
        
        public CustomerStateEnum CustomerStateEnum { get; set; } = CustomerStateEnum.confirm;
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        [EmailAddress]
        public string CustomerAddress { get; set; }
        public TypeCustomerEnum TypeCustomerEnum { get; set; } = TypeCustomerEnum.website;
        public int Prestige { get; set; } = 0;
        public string CMNN { get; set; }
        public string ConfirmCode { get; set; }
        
        public string AuthenticationID { get; set; }
        public string Password { get; set; }
    }
}
