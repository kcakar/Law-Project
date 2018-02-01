using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Law.Admin;
using Law.Test;
using Law.Core;

namespace Law.Admin.Controllers
{
    public class CommonController : Controller
    {
        private static IMemoryCache _cache;

        private static CacheItems _CacheItems;
        public CacheItems CacheItems
        {
            get
            {
                if (!_cache.TryGetValue(CacheKeys.CacheItems, out _CacheItems))
                {
                    // Key not in cache, so get data.
                    _CacheItems = new CacheItems(Common.GetCountries(), Common.GetCities(), Common.GetPractices());

                    // Set cache options.
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        // Keep in cache for this time, reset time if accessed.
                        .SetSlidingExpiration(TimeSpan.FromDays(1));

                    // Save data in cache.
                    _cache.Set(CacheKeys.CacheItems, _CacheItems, cacheEntryOptions);
                }
                return _CacheItems;
            }
        }

        public CommonController(IMemoryCache memoryCache)
        {
            Tester.GenerateTestData();
            _cache = memoryCache;
        }
    }
}