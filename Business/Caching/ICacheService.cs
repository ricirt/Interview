using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Caching
{
    public interface ICacheService
    {
        T Get<T>(string Key);
        void Add(string Key, object Data);
        void Remove(string Key);
        void ClearCache();
        bool Any(string Key);
    }
}
