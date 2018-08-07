using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DAL;
using DAL.Model;

namespace BLL.BLL.Log.Implement
{
    public class ErrorLogsBLL :GenericBLL, IErrorLogsBLL
    {
        public ErrorLogsBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IEnumerable<ErrorLogs> Get(Expression<Func<ErrorLogs, bool>> filter = null)
        {
            return this.unitOfWork.ErrorLogsRepository.Get(filter);
        }
        public int Cout(Expression<Func<ErrorLogs, bool>> filter = null)
        {
            return this.unitOfWork.ErrorLogsRepository.Cout(filter);
        }
        public bool DeleteAll()
        {
           return this.unitOfWork.ErrorLogsRepository.DeleteAll();
        }
    }
}
