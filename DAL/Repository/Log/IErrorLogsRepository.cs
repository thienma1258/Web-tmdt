using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.Log
{
    public interface IErrorLogsRepository : IGenericRepository<ErrorLogs, string>
    {
    }
}
