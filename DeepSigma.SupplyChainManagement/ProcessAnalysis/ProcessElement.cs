
using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

namespace DeepSigma.SupplyChainManagement.ProcessAnalysis;

/// <summary>
/// Proccess element represents a specific step or component within a production process, characterized by its type (Process Step or Buffer), constraints (demand or capacity), and key performance metrics such as available input, demand, capacity, flow rate, cycle time, processing time, labor content, and utilization. This class provides a structured way to analyze and optimize individual elements of a process, helping to identify bottlenecks, constraints, and opportunities for improvement in the overall production system.
/// </summary>
public class ProcessElement
{
    /// <summary>
    /// ProcessElementType specifies the type of process element, which can be either a Process Step or a Buffer. 
    /// This classification helps in understanding the role and function of each element within the overall process flow, allowing for more effective analysis and optimization of the process. 
    /// The type of process element can influence how it is managed, monitored, and improved to enhance overall process performance and efficiency.
    /// </summary>
    public required ProcessElementType ProcessElementType { get; set; }

    /// <summary>
    /// ProcessConstraintType indicates whether the process element is constrained by demand or capacity. 
    /// If the implied utilization is greater than 1, it means that the demand exceeds the capacity, resulting in a capacity constraint. 
    /// Conversely, if the implied utilization is less than or equal to 1, it indicates that there is sufficient capacity to meet the demand, resulting in a demand constraint. 
    /// This classification helps identify bottlenecks and constraints in the process, allowing for targeted improvements and resource allocation to optimize performance.
    /// </summary>
    public ProcessConstraintType ConstraintType => ImpliedUtililization > 1 ? ProcessConstraintType.CapacityConstraint : ProcessConstraintType.DemandConstraint;
   

    /// <summary>
    /// Gets the flow rate, which represents the maximum throughput of the process based on current input, demand, and
    /// capacity constraints.
    /// </summary>
    /// <remarks>The flow rate is determined by the minimum value among available process input, demand, and
    /// capacity. This ensures that the process does not exceed its operational limits and provides insight into the
    /// limiting factor under current conditions.</remarks>
    public decimal FlowRate => Math.Min(AvailableProcessInput, Math.Min(Demand, Capacity));

    /// <summary>
    /// Gets the cycle time, calculated as the inverse of the current flow rate.
    /// </summary>
    /// <remarks>The cycle time represents the duration required to complete one cycle of the process based on
    /// the current flow rate. A flow rate of zero will result in a division by zero error.</remarks>
    public decimal CycleTime => 1 / FlowRate;
    public required TimeSpan ProcessingTime { get; set; }

    /// <summary>
    /// Capacity represents the maximum output or throughput that a process element can achieve under ideal conditions. 
    /// It is a critical metric for understanding the limitations of a process and identifying potential bottlenecks. 
    /// The capacity of a process element can be influenced by various factors such as equipment capabilities, labor availability, and process design. 
    /// By analyzing capacity in conjunction with demand and available input, organizations can make informed decisions about resource allocation, process improvements, and strategies to optimize overall performance and efficiency.
    /// </summary>
    public required decimal Capacity { get; set; }

    /// <summary>
    /// Demand represents the required output or throughput that a process element needs to achieve to meet customer requirements or production goals.
    /// </summary>
    public required decimal Demand { get; set; }

    /// <summary>
    /// Available Process Input represents the amount of input or resources that are available for a process element to utilize in its operations.
    /// It is a critical factor in determining the flow rate and overall performance of the process element, as it directly impacts the ability to meet demand and achieve desired output levels.
    /// A process element with insufficient available input may struggle to meet demand, leading to potential bottlenecks and constraints in the overall process.
    /// If the available process input is less than the demand, it can lead to a supply constraint.
    /// To address this issue, organizations may need to increase the available input through strategies such as adding buffers, line balancing, or improving resource allocation to ensure that the process can meet demand and operate efficiently.
    /// </summary>
    public required decimal AvailableProcessInput { get; set; }

    /// <summary>
    /// Labor content represents the amount of labor required to complete a process element, typically measured in terms of worker time.
    /// </summary>
    public required decimal LaborContent { get; set; }

    /// <summary>
    /// Indicates whether the process element has excess capacity, which occurs when the implied utilization is less than 1.
    /// </summary>
    public bool HasExcessCapacity => ImpliedUtililization < 1;

    /// <summary>
    /// Utilization is a measure of how much of the process's capacity is being utilized based on the current flow rate. 
    /// It is calculated as the ratio of flow rate to capacity. 
    /// If the utilization is greater than 1, it indicates that the flow rate exceeds the process's capacity, leading to a capacity constraint. 
    /// If it is less than or equal to 1, it indicates that there is sufficient capacity available to meet the flow rate, leading to a demand constraint. 
    /// This metric helps identify bottlenecks and constraints in the process and can inform decisions about process improvements and resource allocation.
    /// </summary>
    public decimal Utililization => FlowRate / Capacity;

    /// <summary>
    /// Implied Utilization is a measure of how much of the process's capacity is being utilized based on the demand. It is calculated as the ratio of demand to capacity. If the implied utilization is greater than 1, it indicates that the demand exceeds the process's capacity, leading to a capacity constraint. If it is less than 1, it indicates that there is excess capacity available to meet the demand, leading to a demand constraint. This metric helps identify bottlenecks and constraints in the process and can inform decisions about process improvements and resource allocation.
    /// </summary>
    public decimal ImpliedUtililization => Demand / Capacity;

    /// <summary>
    /// Calculates the time required to produce a specified number of units, assuming the process operates at full flow
    /// rate.
    /// </summary>
    /// <remarks>The flow rate must be greater than zero to avoid division by zero errors. This method assumes
    /// a constant flow rate throughout the production process.</remarks>
    /// <param name="x_number_of_units">The number of units to produce. Must be a positive integer.</param>
    /// <returns>The time, in decimal format, required to produce the specified number of units.</returns>
    public decimal TimeToProduceXUnitsAssumingFullProcess(int x_number_of_units) => x_number_of_units / FlowRate;
}
