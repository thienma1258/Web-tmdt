using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public interface IDistrictBLL
    {
        Task<IEnumerable<District>> Get();
    }
}
