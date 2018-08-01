using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CacheHelpers
{
    public class CacheMemory
    {
        private IMemoryCache _cache;
        public CacheMemory(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }
        public T Get<T>(string strKey)
        {
           return _cache.Get<T>(strKey);
        }
        public void Set(object objData,string strKey)
        {
            _cache.Set(strKey, objData);
        }
    }
}
