using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.PM
{
    public interface IProductBLL:IGenericBLL<Product,string>
    {
        Product SearchByUrl(string url);

    }
}
