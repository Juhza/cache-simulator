using CacheSimulator.Enums;

namespace CacheSimulator.Entities
{
    public class CacheConfiguration
    {
        private const int MAX_SIZE = 2048;

        public PlacementPolicy PlacementPolicy { get; init; }
        public int NumberOfBlocks { get; init; }
        public int BlockSize { get; init; }
        public int TotalCacheSize { get; init; }

        public CacheConfiguration(PlacementPolicy placementPolicy, int numberOfBlocks, int blockSize)
        {
            if (numberOfBlocks > MAX_SIZE || blockSize > MAX_SIZE)
                throw new Exception("cannotSurpassMaxSize");

            if (!numberOfBlocks.IsPowerOfTwo() || !blockSize.IsPowerOfTwo())
                throw new Exception("shouldBeToThePowerOfTwo");

            PlacementPolicy = placementPolicy;
            NumberOfBlocks = numberOfBlocks;
            BlockSize = blockSize;
            TotalCacheSize = blockSize * 4 * numberOfBlocks;
        }
    }
}
