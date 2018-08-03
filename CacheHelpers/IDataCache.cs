using System;
using System.Collections.Generic;
using System.Text;

namespace CacheHelpers
{
    public interface IDataCache
    {
        T Get<T>(string strKey);
        void Set(object objData, string strKey);

     }       
}
