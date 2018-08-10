using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.PM
{
    public interface IMainGroupBLL: IGenericBLL<MainGroup, string>
    {
        MainGroup SearchByUrl(string url);
    }
}
