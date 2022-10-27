namespace CacheSimulator.novo
{
    public class SetAssociativeCache : Cache
    {
        public int SetSize;
        public SetAssociativeCache(int blockSize, int wordSize, int setSize) : base(blockSize, wordSize)
        {
            SetSize = setSize;
        }
    }
}

