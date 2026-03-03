namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Specifies the types of constraints that can limit a process, such as capacity or demand constraints.
/// </summary>
/// <remarks>Use this enumeration to identify whether a process is limited by available resources or by market
/// demand. This distinction can help determine appropriate strategies for process improvement or optimization.
/// </remarks>
public enum ProcessConstraintType
{
    /// <summary>
    /// Indicates the process is constrained by the capacity of resources, such as machinery, labor, or production lines. 
    /// Also know as "Resource Constraint", "Throughput Constraint", or "Supply Constraint".
    /// This constraint limits the maximum output or throughput of the process, and addressing it may involve optimizing resource allocation, increasing capacity, or improving efficiency to meet demand. 
    /// </summary>
    CapacityConstraint,
    /// <summary>
    /// Indicates the process is constrained by the demand for its output. 
    /// This constraint limits the production or service levels based on customer demand, market conditions, or sales forecasts.
    /// </summary>
    DemandConstraint,
}
