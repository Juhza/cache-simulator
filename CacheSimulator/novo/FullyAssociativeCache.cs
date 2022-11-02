namespace CacheSimulator.novo
{
    public class FullyAssociativeCache : Cache
    {
        public FullyAssociativeCache(int blockSize, int wordSize) : base(blockSize, wordSize) { }

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
