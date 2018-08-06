using Common.Enum.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
    public class MainGroup:SeoObject
    {
        public string Name { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public string Description { get; set; }
        public TypeSexEnum TypeSex { get; set; } = TypeSexEnum.All;
        public virtual ICollection<SubGroup> SubGroups { get; set; }
    

    }
}
