using CacheSimulator.Enums;

namespace CacheSimulator.Models
{
    public class CacheConfigurationModel
    {
        public int BlockSize { get; set; }
        public int WordSize { get; set; }
        public int SetSize { get; set; }
        public PlacementPolicy PlacementPolicy { get; set; }
        public BlockReplacementPolicy BlockReplacementPolicy { get; set; }

        public CacheConfigurationModel()
        {
            BlockSize = 1;
            WordSize = 1;
            SetSize = 1;
            PlacementPolicy = PlacementPolicy.DirectMapping;
            BlockReplacementPolicy = BlockReplacementPolicy.LRU;
        }
    }
}
