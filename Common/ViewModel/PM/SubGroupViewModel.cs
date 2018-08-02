﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel.PM
{
    public class SubGroupViewModel
    {
        public string idSubGroup { get; set; }
        public string nameSubGroup { get; set; }
        public string Description { get; set; }
        public string defaultImages { get; set; }
        public virtual MainGroupViewModel MainGroup { get; set; }
        public int typeSex { get; set; }
    }
}
