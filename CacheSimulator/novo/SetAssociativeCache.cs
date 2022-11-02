namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public int SetSize;

        public SetAssociativeCache(int blockSize, int wordSize, int setSize) : base(blockSize, wordSize)
        {
            SetSize = setSize;
        }

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

