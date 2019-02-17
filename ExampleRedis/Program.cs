using System;
using ExampleRedis.Services;
namespace ExampleRedis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello World!");
            IRedisService redisService = new RedisService();
            Console.Write("Connection : "+redisService.GetRedisClient());
            Console.WriteLine("Save in memory database");
            program.ReadData();
            program.SaveData();
            Console.ReadKey();
        }
        public void SaveData()
        {
            IRedisService redisService = new RedisService();
            var cache = redisService.GetRedisClient();
            for(int i=0;i<10;i++)
            {
                var value = cache.StringSet($"value : {0}",i);
            }
        }
        public void ReadData()
        {
            IRedisService redisService = new RedisService();
            var cache = redisService.GetRedisClient();
            for (int i = 0; i < 10; i++)
            {
                var value = cache.StringGet($"value : {i}");
                Console.WriteLine($"Value = {value}");
            }
        }
    }
}
