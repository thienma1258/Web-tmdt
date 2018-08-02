using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class GenericBLL
    {
        public IUnitOfWork unitOfWork;
        public GenericBLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
