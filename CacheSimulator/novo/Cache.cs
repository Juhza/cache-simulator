namespace CacheSimulator.novo
{
    public abstract class Cache
    {
        public int BlockSize;
        public int WordSize;
        public int CacheSize;
        public int hits;
        public int misses;
        public string[] Tags;
        public Word[,] Blocks;
        public bool[] DirtyBits;

        public Cache(int blockSize, int wordSize)
        {
            BlockSize = blockSize;
            WordSize = wordSize;
            CacheSize = blockSize * wordSize * 4;

            hits = 0;
            misses = 0;

            Tags = new string[blockSize];
            Blocks = new Word[blockSize, wordSize];
            DirtyBits = new bool[blockSize];
        }

        public abstract void InsertWord(Word word, Address address);

        public abstract Word RetrieveWord(Address address);
    }
}

