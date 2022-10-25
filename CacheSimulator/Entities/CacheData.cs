namespace CacheSimulator.Entities
{
    public class CacheData
    {
        public int Data { get; init; }
        public DateTime RegisteredAt { get; init; }

        public CacheData(int data)
        {
            Data = data;
            RegisteredAt = DateTime.Now;
        }
    }
}
