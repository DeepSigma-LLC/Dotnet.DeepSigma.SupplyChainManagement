namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Specifies the primary sources of wait time within a supply chain.
/// </summary>
public enum PrimarySourceOfWaitTime
{
    /// <summary>
    /// Demand exceeds capacity occurs when the demand for a product or service exceeds the available capacity to produce or deliver it. 
    /// This can lead to delays and increased wait times for customers, as the supply chain struggles to keep up with the demand. 
    /// It can also result in lost sales and decreased customer satisfaction if the wait times become too long.
    /// </summary>
    DemandExceedsCapacity,
    /// <summary>
    /// Variability refers to the fluctuations and inconsistencies that can occur in a supply chain, such as changes in demand, production delays, or transportation issues, ect.
    /// Many factors can contribute to variability, including external factors such as weather or economic conditions, as well as internal factors such as equipment breakdowns or labor shortages.
    /// </summary>
    Variability
}
