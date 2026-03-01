

namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// Specifies the different sources of variability that can impact a production process.
/// </summary>
public enum SourcesOfVariability
{
    /// <summary>
    /// Variability from the inflow of flow units refers to the fluctuations and inconsistencies that can occur in the arrival of flow units into a production process.
    /// </summary>
    VariabilityFromInflowOfFlowUnits,
    /// <summary>
    /// Variability from processing times refers to the fluctuations and inconsistencies that can occur in the time it takes to process flow units within a production process.
    /// </summary>
    VariabilityFromProcessingTimes,
    /// <summary>
    /// Random availability of resources refers to the fluctuations and inconsistencies that can occur in the availability of resources, such as labor, equipment, or materials, that are necessary for the production process.
    /// </summary>
    RandomAvailabilityOfResources,
    /// <summary>
    /// Randomness in routing decisions refers to the fluctuations and inconsistencies that can occur in the decisions made regarding the routing of flow units through a production process, such as which machines or workstations they are processed at, or which paths they take through the production system.
    /// </summary>
    RandomnessInRoutingDecisions,
}
