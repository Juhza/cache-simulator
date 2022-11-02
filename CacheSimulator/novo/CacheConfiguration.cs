using CacheSimulator.Enums;

namespace CacheSimulator.novo
{
    public class CacheConfiguration
    {
        public int BlockSize;
        public int WordSize;
        public int SetSize;
        public PlacementPolicy PlacementPolicy;
        public BlockReplacementPolicy BlockReplacementPolicy;

        public CacheConfiguration(int blockSize, int wordSize, int setSize, PlacementPolicy placementPolicy, BlockReplacementPolicy blockReplacementPolicy)
        {
            BlockSize = blockSize;
            WordSize = wordSize;
            SetSize = setSize;
            PlacementPolicy = placementPolicy;
            BlockReplacementPolicy = blockReplacementPolicy;
        }
    }
}

