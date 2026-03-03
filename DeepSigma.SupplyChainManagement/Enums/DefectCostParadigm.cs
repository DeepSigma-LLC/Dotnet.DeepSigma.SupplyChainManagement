

namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// The DefectCostParadigm enum represents the different stages at which a defect can be detected in the production process and the associated costs of addressing those defects.
/// </summary>
public enum DefectCostParadigm
{
    /// <summary>
    /// The cost of a defect detected prior to the bottleneck is significantly lower than the cost of a defect detected after the bottleneck.
    /// This is because defects detected early can be addressed with minimal disruption to the production process.
    /// The cost is primarily associated with the time and resources required to fix the defect or a maximum the cost of material waste (in the case where defects are detected during the production process and the defective product needs to be scrapped).
    /// Meanwhile defects detected later can lead to more significant disruptions, such as wasted production capacity.
    /// </summary>
    PriorToBottleneck,
    /// <summary>
    /// The cost of a defect detected after the bottleneck is higher than the cost of a defect detected prior to the bottleneck.
    /// This is because defects detected at this stage can cause more significant disruptions, such as wasted production capacity.
    /// </summary>
    AfterBottleneck,
    /// <summary>
    /// The cost of a defect detected when the product is in the market is the highest. 
    /// This is because defects detected at this stage can lead to significant financial losses, damage to brand reputation, and customer dissatisfaction.
    /// </summary>
    ProductInMarket
}
