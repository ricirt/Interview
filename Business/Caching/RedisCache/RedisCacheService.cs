using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Caching.RedisCache
{

    public class RedisCacheService : ICacheService
    {
        private readonly RedisServer _redisServer;

        public RedisCacheService(RedisServer redisServer)
        {
            _redisServer = redisServer;
        }

        public void Add(string Key, object Data)
        {
            string jsonData = JsonConvert.SerializeObject(Data);
            _redisServer.Database.StringSet(Key, jsonData);
        }

        public bool Any(string Key)
        {
            return _redisServer.Database.KeyExists(Key);
        }

        public void ClearCache()
        {
            _redisServer.FlushDatabase();
        }

        public T Get<T>(string Key)
        {
            if (Any(Key))
            {
                string jsonData = _redisServer.Database.StringGet(Key);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            return default;
        }

        public void Remove(string Key)
        {
            _redisServer.Database.KeyDelete(Key);
        }
    }
}
