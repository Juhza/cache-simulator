using CacheSimulator.Entities;

namespace CacheSimulator.Services
{
    public class CachePerformanceResultsService
    {
        private Cache _cache = null!;
        private CacheConfiguration _cacheConfiguration = null!;
        
        public void GetCachePerformanceResults(CacheConfiguration cacheConfiguration)
        {
            _cache = new Cache(cacheConfiguration);
            _cacheConfiguration = cacheConfiguration;

            // calcular cfe configuração

            // retornar dados p output
        }
    }
}
