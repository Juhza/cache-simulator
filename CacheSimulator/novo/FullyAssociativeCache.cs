namespace CacheSimulator.novo
{
    public class FullyAssociativeCache : Cache
    {
        public FullyAssociativeCache(CacheConfiguration cacheConfiguration) : base(cacheConfiguration) { }

        override
        public void InsertWord(Word word, Address address)
        {
            throw new NotImplementedException();
        }

        override
        public Word RetrieveWord(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
