using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.PM
{
    public interface IBrandBLL:IGenericBLL<Brand, string>
    {
        Brand SearchByUrl(string url);
    }
}
