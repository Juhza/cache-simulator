namespace CacheSimulator.novo
{
    public class DirectMappingCache : Cache
    {
        public DirectMappingCache(int blockSize, int wordSize) : base(blockSize, wordSize) { }

        public override void InsertWord(Word word, Address address)
        {
            throw new NotImplementedException();
        }

        public override Word RetrieveWord(Address address)
        {
            throw new NotImplementedException();
        }
    }
}

