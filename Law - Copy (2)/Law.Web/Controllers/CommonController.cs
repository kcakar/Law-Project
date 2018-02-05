using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Test;
using Law.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Law.Web.Controllers
{
    public class CommonController : Controller
    {
        private static IMemoryCache _cache;

        private static FilterModel _filterModel;
        public FilterModel FilterModel
        {
            get {
                if (!_cache.TryGetValue(CacheKeys.FilterModel, out _filterModel))
                {
                    // Key not in cache, so get data.
                    _filterModel = new FilterModel(Common.GetCountries(), Common.GetCities(), Common.GetPractices());

                    // Set cache options.
                    var cacheEntryOptions = new MemoryCacheEntryOptions()
                        // Keep in cache for this time, reset time if accessed.
                        .SetSlidingExpiration(TimeSpan.FromDays(1));

                    // Save data in cache.
                    _cache.Set(CacheKeys.FilterModel, _filterModel, cacheEntryOptions);
                }
                return _filterModel;
            }
        }

        public CommonController(IMemoryCache memoryCache)
        {
            Tester.GenerateTestData();
            _cache = memoryCache;
        }

    }
}