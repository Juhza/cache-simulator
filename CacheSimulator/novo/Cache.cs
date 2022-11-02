using CacheSimulator.Enums;

namespace CacheSimulator.novo
{
    public abstract class Cache
    {
        public int BlockSize;
        public int WordSize;
        public int SetSize;
        public int BlockSizeDecimal;
        public int WordSizeDecimal;
        public int SetSizeDecimal;
        public PlacementPolicy PlacementPolicy;
        public BlockReplacementPolicy BlockReplacementPolicy;
        public int CacheSize;
        public string[] Tags;
        public Word[,] Blocks;
        public bool[] DirtyBits;
        public int hits;
        public int misses;

        public Cache(CacheConfiguration cacheConfiguration)
        {
            BlockSize = cacheConfiguration.BlockSize;
            WordSize = cacheConfiguration.WordSize;
            SetSize = cacheConfiguration.SetSize;

            BlockSizeDecimal = (int)Math.Pow(2, BlockSize);
            WordSizeDecimal = (int)Math.Pow(2, WordSize);
            SetSizeDecimal = (int)Math.Pow(2, SetSize);

            PlacementPolicy = cacheConfiguration.PlacementPolicy;
            BlockReplacementPolicy = cacheConfiguration.BlockReplacementPolicy;

            CacheSize = BlockSizeDecimal * WordSizeDecimal;

            Tags = new string[(int)Math.Pow(2, BlockSize)];
            Blocks = new Word[(int)Math.Pow(2, BlockSize), (int)Math.Pow(2, WordSize)];
            DirtyBits = new bool[(int)Math.Pow(2, BlockSize)];

            hits = 0;
            misses = 0;
        }

        public abstract void InsertWord(Word word, Address address);

        public abstract Word RetrieveWord(Address address);
    }
}

