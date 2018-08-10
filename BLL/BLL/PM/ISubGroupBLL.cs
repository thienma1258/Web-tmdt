using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.PM
{
    public interface ISubGroupBLL : IGenericBLL<SubGroup, string>
    {
        SubGroup SearchByUrl(string url);

    }
}
