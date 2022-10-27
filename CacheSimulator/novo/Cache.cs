namespace CacheSimulator.novo
{
    public abstract class Cache
    {
        public int BlockSize;
        public int WordSize;
        public string[] Tags;
        public byte[,] Blocks;
        public bool[] DirtyBits;

        public Cache(int blockSize, int wordSize)
        {
            BlockSize = blockSize;
            WordSize = wordSize;
            Tags = new string[blockSize];
            Blocks = new byte[blockSize, wordSize];
            DirtyBits = new bool[blockSize];
        }

        public abstract void InsertData(byte data, string address);

        public abstract byte RetrieveData(string address);
    }
}

