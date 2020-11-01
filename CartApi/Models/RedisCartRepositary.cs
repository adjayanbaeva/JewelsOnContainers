using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Models
{
    public class RedisCartRepositary : ICartRepositary
    {
        private readonly ConnectionMultiplexer _redis;
        private readonly IDatabase _database;

        public RedisCartRepositary(ConnectionMultiplexer redis)
        {
            _redis = redis;
            _database = _redis.GetDatabase();
        }
        public Task<bool> DeleteCartAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetCartAsync(string cartId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> UpdateCartAsync(Cart basket)
        {
            throw new NotImplementedException();
        }
    }
}
