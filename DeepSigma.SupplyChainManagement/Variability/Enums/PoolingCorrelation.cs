
namespace DeepSigma.SupplyChainManagement.Variability.Enums;

/// <summary>
/// Pooling correlation refers to the relationship between the demand (or supply) patterns of different pools in a supply chain.
/// Pools may refer to different warehouses, distribution centers, customer or product segments.
/// The correlation can be positive, negative, or independent, and it has implications for how pooling can help reduce variability and improve service levels in the supply chain.
/// </summary>
public enum PoolingCorrelation
{
    /// <summary>
    /// Positively correlated pools are those where the demand (or supply) in one pool is likely to be similar to the demand (or supply) in another pool. 
    /// For example, if two pools serve similar customer segments or geographic regions, their demand patterns may be positively correlated.
    /// In such cases, pooling will not significantly reduce variability, as the demand (or supply) in both pools will tend to fluctuate together.
    /// </summary>
    PositivelyCorrelatedPools,
    /// <summary>
    /// Negatively correlated pools are those where the demand (or supply) in one pool is likely to be opposite to the demand (or supply) in another pool.
    /// For example, if one pool experiences high demand while another experiences low demand, their demand patterns are negatively correlated.
    /// In such cases, pooling can help balance the fluctuations, leading to reduced variability and improved service levels.
    /// </summary>
    NegativelyCorrelatedPools,
    /// <summary>
    /// Independent pools are those where the demand (or supply) in one pool is not related to the demand (or supply) in another pool.
    /// In such cases, pooling can help reduce variability through economies of scale to some extent, but the effect may not be as pronounced as with negatively correlated pools.
    /// </summary>
    IndependentPools,
}
