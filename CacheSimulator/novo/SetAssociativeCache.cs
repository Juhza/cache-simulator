namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public SetAssociativeCache(CacheConfiguration cacheConfiguration) : base(cacheConfiguration) { }

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

