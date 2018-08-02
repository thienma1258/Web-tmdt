using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel.PM
{
    public class MainGroupViewModel
    {
        public string nameMainGroup { get; set; }
        public string Description { get; set; }
        public string defaultImages { get; set; }
        public int typeSex { get; set; }
        public virtual SubGroupViewModel SubGroup{get;set;}
    }
}
