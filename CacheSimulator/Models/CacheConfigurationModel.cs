using CacheSimulator.Enums;

namespace CacheSimulator.Models
{
    public class CacheConfigurationModel
    {
        public PlacementPolicy PlacementPolicy { get; set; }
        public int NumberOfBlocks { get; set; }
        public int BlockSize { get; set; }
    }
}
