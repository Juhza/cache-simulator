namespace CacheSimulator.novo
{
    public class DirectMappingCache : Cache
    {
        public DirectMappingCache(int blockSize, int wordSize) : base(blockSize, wordSize)
        {

        }

        public override void InsertData(byte data, string address)
        {
            throw new NotImplementedException();
        }

        public override byte RetrieveData(string address)
        {
            throw new NotImplementedException();
        }
    }
}

