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

    }
}
