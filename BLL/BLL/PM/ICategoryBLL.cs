﻿using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.PM
{
    public interface ICategoryBLL:IGenericBLL<Category,string>
    {
        Category SearchByUrl(string url);

    }
}
