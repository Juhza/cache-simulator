namespace CacheSimulator.Entities
{
    public class Cache
    {
        public CacheConfiguration CacheConfiguration { get; init; }
        public CacheData[] Blocks { get; init; }

        public Cache(CacheConfiguration cacheConfiguration)
        {
            CacheConfiguration = cacheConfiguration;
            Blocks = new CacheData[cacheConfiguration.TotalCacheSize];
        }

        public void InsertDataAtPosition(int data)
        {
            var cacheData = new CacheData(data);

            // ver espaço onde botar
        }
    }
}
