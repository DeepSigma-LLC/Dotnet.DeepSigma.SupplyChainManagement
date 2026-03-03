namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Specifies the two primary types of events that led to a reduction in flow rate due to resource availability issues within the system.
/// </summary>
/// <remarks>
/// Blocking and starving can be avoided by adding buffers.
/// The buffers would have to contain a sufficient number of flow units so as to avoid starvation of the downstream resource. 
/// At the same time, the buffer should have enough space to prevent the resource upstream from ever being blocked.
/// This may not always be 100% possible since there is often a cost to inventory by it is a good goal to target.
/// </remarks>
public enum FlowRateReductionEvent
{
    /// <summary>
    /// Represents a resource that has been blocked from access or usage due to specific conditions.
    /// </summary>
    BlockedResource,
    /// <summary>
    /// Represents a resource that is currently starved, indicating that it is unable to proceed due to lack of
    /// necessary conditions or inputs.
    /// </summary>
    StarvedResource,
}
