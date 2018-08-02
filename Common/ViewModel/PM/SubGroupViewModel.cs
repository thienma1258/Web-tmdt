using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel.PM
{
    public class SubGroupViewModel
    {
        public string nameMainGroup { get; set; }
        public string metaDescription { get; set; }
        public string defaultImages { get; set; }
        public virtual MainGroupViewModel MainGroup { get; set; }
        public int typeSex { get; set; }
    }
}
