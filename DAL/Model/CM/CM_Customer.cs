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
        [Display(Name ="Tên khách hàng")]
        public string CustomerName { get; set; }
        [Display(Name = "Số điện thoại KH")]
        public string CustomerPhone { get; set; }
     
        public TypeCustomerEnum TypeCustomerEnum { get; set; } = TypeCustomerEnum.website;
        public int Prestige { get; set; } = 0;
        public string CMNN { get; set; }
        public string ConfirmCode { get; set; }
        public string DefaultImage { get; set; }
    
    }
}
