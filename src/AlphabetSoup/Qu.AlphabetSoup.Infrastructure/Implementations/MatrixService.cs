using Qu.AlphabetSoup.Application.Interfaces;
using StackExchange.Redis.Extensions.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Qu.AlphabetSoup.Infrastructure.Implementations
{
    public class MatrixService : IMatrixService
    {
        private readonly IRedisCacheClient _cacheClient;

        public MatrixService(IRedisCacheClient cacheClient)
        {
            _cacheClient = cacheClient;
        }

        public async Task CreateMatrixAsync(IEnumerable<string> matrix)
        {
            var key = @"matrix";
            var status = await _cacheClient.Db0.AddAsync(key, matrix);
            if(status)
            {
                var getMatrix = _cacheClient.Db0.GetAsync<IEnumerable<string>>(key);
                if (getMatrix != null)
                    status = await _cacheClient.Db0.RemoveAsync(key);
            }
        }
    }
}
