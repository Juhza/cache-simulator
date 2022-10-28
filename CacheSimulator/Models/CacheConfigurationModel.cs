using CacheSimulator.Enums;

namespace CacheSimulator.Models
{
    public class CacheConfigurationModel
    {
        public PlacementPolicy PlacementPolicy { get; set; }
        public BlockReplacementPolicy BlockReplacementPolicy { get; set; }
        public int NumberOfBlocks { get; set; }
        public int BlockSize { get; set; }
        public int SetSize { get; set; }
    }
}
