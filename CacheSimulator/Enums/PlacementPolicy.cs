using System.ComponentModel;

namespace CacheSimulator.Enums
{
    public enum PlacementPolicy
    {
        [Description("Direct Mapping")]
        DirectMapping,
        [Description("Fully Associative")]
        FullyAssociative,
        [Description("N-Way Set Associative")]
        NWaySetAssociative
    }
}
