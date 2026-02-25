
namespace DeepSigma.SupplyChainManagement.Enums;

public enum ProcessAnalysisComponent
{
    /// <summary>
    /// Time taken to complete an activity, including processing time, waiting time, and any other time-related factors that contribute to the overall duration of a process. This component is crucial for identifying bottlenecks and optimizing workflow efficiency.
    /// Also known as "Process Time" or "Cycle Time," it encompasses the total time from the start to the completion of a process, including both value-added and non-value-added activities. Understanding Activity Time is essential for improving process performance and reducing lead times in supply chain management.
    /// </summary>
    ActivityTime,
    /// <summary>
    /// Flow unit refers to the individual item, product, or unit of work that moves through a process or supply chain. 
    /// It is the basic entity that is being processed, transformed, or transported at each stage of the workflow.
    /// </summary>
    FlowUnit,
    /// <summary>
    /// Inventory refers to the stock of materials, products, or resources that are held at various stages of a process or supply chain. 
    /// Aka "Buffer" or "Stock," it represents the quantity of items that are available to meet demand or support production at any given time.
    /// It can include raw materials, work-in-progress items, and finished goods. Inventory is a critical component for ensuring that production and operations can continue smoothly without interruptions due to shortages. 
    /// However, excessive inventory can lead to increased holding costs and inefficiencies, while insufficient inventory can result in stockouts and lost sales. 
    /// Managing inventory effectively is essential for optimizing supply chain performance and meeting customer demand.
    /// </summary>
    Inventory,
    /// <summary>
    /// Flow Rate refers to the speed at which materials, information, or products move through a process or supply chain. 
    /// It is typically measured in units per time (e.g., items per hour, tons per day) and is a critical component for assessing the efficiency and capacity of a process. A higher flow rate indicates a more efficient process, while a lower flow rate may signal bottlenecks or inefficiencies that need to be addressed. 
    /// Understanding and optimizing flow rate is essential for improving overall supply chain performance and meeting customer demand effectively.
    /// Aka "Throughput" or "Process Flow Rate," it represents the rate at which a process produces output or completes tasks. It is a key performance indicator (KPI) for evaluating the efficiency of a process and is often used to identify areas for improvement in supply chain management.
    /// </summary>
    FlowRate,

    FlowTime,
    /// <summary>
    /// Capacity refers to the maximum output or throughput that a process can achieve under normal operating conditions. 
    /// It is determined by factors such as available resources, equipment capabilities, labor, and process design.
    /// </summary>
    Capacity,
    /// <summary>
    /// Utilization is a measure of how effectively the available capacity of a process is being used. 
    /// It is typically expressed as a percentage and calculated by dividing the actual output or throughput by the maximum capacity.
    /// </summary>
    Utilization,
    /// <summary>
    /// Critical Path refers to the sequence of activities or stages in a process that determines the overall duration of the process.
    /// </summary>
    CriticalPath,
    /// <summary>
    /// Process Boundaries refer to the defined limits or scope of a process, including the start and end points, as well as the activities, resources, and interactions that occur within those boundaries.
    /// </summary>
    ProcessBoundaries,
    /// <summary>
    /// Bottleneck refers to the stage or component of a process that has the lowest capacity or flow rate, which limits the overall performance and throughput of the entire process.
    /// Bottlenecks are identified where the implied utilization is highest, meaning that the demand on that stage exceeds its capacity, causing delays and inefficiencies in the process.
    /// </summary>
    Bottleneck,
    /// <summary>
    /// Base Level Excess Capacity refers to the amount of capacity that is available in a process beyond what is currently being utilized.
    /// </summary>
    BaseLevelExcessCapacity,
    /// <summary>
    /// Workload refers to the amount of work or demand placed on a process or resource within a given time period. 
    /// It is often measured in terms of the number of tasks, units, or activities that need to be completed.
    /// </summary>
    Workload
}
