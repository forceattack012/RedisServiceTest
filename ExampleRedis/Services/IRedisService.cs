using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleRedis.Services
{
    public interface IRedisService
    {
        IDatabase GetRedisClient();
    }
}
