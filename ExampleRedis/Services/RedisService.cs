using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace ExampleRedis.Services
{
    class RedisService : IRedisService
    {
        readonly IDatabase _redisClient;

        public RedisService()
        {
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase database = connection.GetDatabase();
            _redisClient = database;
        }
        public IDatabase GetRedisClient()
        {
            return _redisClient;
        }
    }
}
