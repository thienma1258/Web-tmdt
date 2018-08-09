using Common.Enum.PM;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.MainGroup
{
    public class EditMainGroupViewModel
    {
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        public IFormFile DefaultImage { get; set; }
        [MaxLength(80)]
        [MinLength(5)]
        [Required]
        [DisplayName(" Mô tả:")]
        public string Description { get; set; }
        [EnumDataType(typeof(TypeSexEnum))]
        public Common.Enum.PM.TypeSexEnum TypeSex { get; set; } = Common.Enum.PM.TypeSexEnum.All;
        public string OldImage { get; set; }
    }
}
