using Common.Enum.SM;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.CM
{
    public class CM_Customer: IdentityUser
    {
        
        public CustomerStateEnum CustomerStateEnum { get; set; } = CustomerStateEnum.confirm;
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
     
        public TypeCustomerEnum TypeCustomerEnum { get; set; } = TypeCustomerEnum.website;
        public int Prestige { get; set; } = 0;
        public string CMNN { get; set; }
        public string ConfirmCode { get; set; }
        
    
    }
}
