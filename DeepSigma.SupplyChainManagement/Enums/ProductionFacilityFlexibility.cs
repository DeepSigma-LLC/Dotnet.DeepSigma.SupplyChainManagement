
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// Specifies the levels of flexibility available to production facilities within a manufacturing system.
/// </summary>
/// <remarks>This enumeration is used to categorize production strategies based on their ability to adapt to
/// changing product demand and manage inventory costs. Selecting the appropriate flexibility level can impact
/// operational efficiency, responsiveness to market fluctuations, and overall supply chain performance.</remarks>
public enum ProductionFacilityFlexibility
{
    /// <summary>
    /// Inflexibility refers to a production system where each production facility is dedicated to producing a specific product or a limited range of products, with no capability to switch between different products.
    /// This lack of flexibility can lead to increased inventory costs and challenges in managing demand uncertainty, as plants may not be able to respond effectively to fluctuations in demand for different products.
    /// </summary>
    Inflexibility,
    /// <summary>
    /// Aka chaining in supply chain management, partial flexibility links production facilities to specific subsets of products, allowing plants to handle overflow from others. 
    /// This cost-effective strategy provides 80–90% of the benefits of full flexibility by reducing inventory costs and managing demand uncertainty without the high expense of making every plant capable of producing all products.
    /// </summary>
    PartialFlexibility,
    /// <summary>
    /// Full flexibility allows any production facility to produce any product, providing maximum responsiveness to demand fluctuations and minimizing inventory costs.
    /// This approach offers the greatest agility in managing demand uncertainty, but it comes with significantly higher costs due to the need for extensive equipment, training, and operational complexity to enable every plant to produce all products.
    /// </summary>
    FullFlexibility,
}
