using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.BLL.Log
{
    public interface IErrorLogsBLL
    {
        int Cout(Expression<Func<ErrorLogs, bool>> filter = null);
        IEnumerable<ErrorLogs> Get(Expression<Func<ErrorLogs, bool>> filter = null);
        bool DeleteAll();
        ErrorLogs Find(string ID);
    }
}
