
namespace DeepSigma.SupplyChainManagement.Enums;

public enum Terminology
{
    /// <summary>
    /// Time taken to complete an activity, including processing time, waiting time, and any other time-related factors that contribute to the overall duration of a process. 
    /// This component is crucial for identifying bottlenecks and optimizing workflow efficiency.
    /// Also known as "Process Time", "Service Time," it encompasses the total time from the start to the completion of a process, including both value-added and non-value-added activities. 
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
    /// </summary>
    Inventory,
    /// <summary>
    /// Flow Rate refers to the speed at which materials, information, or products move through a process or supply chain. 
    /// It is typically measured in units per time (e.g., items per hour, tons per day) and is a critical component for assessing the efficiency and capacity of a process. A higher flow rate indicates a more efficient process, while a lower flow rate may signal bottlenecks or inefficiencies that need to be addressed. 
    /// Understanding and optimizing flow rate is essential for improving overall supply chain performance and meeting customer demand effectively.
    /// Aka "Throughput" or "Process Flow Rate," it represents the rate at which a process produces output or completes tasks. It is a key performance indicator (KPI) for evaluating the efficiency of a process and is often used to identify areas for improvement in supply chain management.
    /// </summary>
    FlowRate,
    /// <summary>
    /// Flow Time refers to the total time it takes for a flow unit to move through the entire process, from the moment it enters the system until it exits as a finished product or service.
    /// </summary>
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
    /// Little's Law is a fundamental principle in queuing theory that relates the average number of items in a system (L), the average arrival rate of items (λ), and the average time an item spends in the system (W) through the formula L = λW.
    /// </summary>
    LittlesLaw,
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
    Workload,
    /// <summary>
    /// Line Balancing is the process of optimizing the allocation of tasks and resources across different stages of a production line or workflow to achieve a balanced and efficient flow of work.
    /// </summary>
    LineBalancing,
    /// <summary>
    /// Cycle Time refers to the time between two flow units.
    /// </summary>
    CycleTime,
    /// <summary>
    /// Average Labor Utilization refers to the average percentage of time that labor resources are actively engaged in productive work within a process or supply chain.
    /// </summary>
    AverageLaborUtiltization,
    /// <summary>
    /// Span of control in process analysis refers to the number of task or minutes that a worker or machine can handle within a given time period. 
    /// It is a measure of the workload or capacity of a resource and is used to determine how many tasks or units can be assigned to that resource without overloading it.
    /// </summary>
    SpanOfControl,

    WorkCell,
    /// <summary>
    /// Slack Time is a term from Project Management that refers to the amount of time that a process or resource has available beyond what is required to complete its tasks or meet demand.
    /// If a process or resource has slack time, it means that it has some flexibility in its schedule and can accommodate unexpected delays or changes without causing disruptions to the overall workflow.
    /// </summary>
    SlackTime,
    /// <summary>
    /// Operational Value Driver refers to the key factors or activities within a process that directly contribute to creating value for customers and stakeholders.
    /// Small changes to operational value drivers can have a significant impact on the overall performance and profitability of a process or supply chain, making them critical areas for analysis and improvement.
    /// Consultants and practitioners often focus on identifying and optimizing operational value drivers to enhance efficiency, reduce costs, and improve customer satisfaction.
    /// </summary>
    OperationalValueDriver,


    ProcessCycleTime,
    /// <summary>
    /// Batch production process is a manufacturing method where products are produced in groups or batches rather than in a continuous flow.
    /// </summary>
    BatchProductionProcess,
    /// <summary>
    /// Continuous flow production process is a manufacturing method where products are produced in a continuous, uninterrupted flow, with each stage of the production process seamlessly connected to the next.
    /// </summary>
    ContinuousFlowProductionProcess,
    /// <summary>
    /// Mixed model production process eliminates the need for inventories, but requires a high degree of flexibility in the production process, as well as a well-coordinated supply chain to ensure that materials and components are available when needed.
    /// </summary>
    MixedModelProductionProcess,
    /// <summary>
    /// Single Minute Exchange of Die (SMED) is a lean manufacturing technique that focuses on reducing the time it takes to changeover a production process from one product or batch to another.
    /// It aims to minimize downtime and increase flexibility by streamlining the changeover process, allowing for faster transitions between different products or batches.
    /// Faster changeovers can lead to increased production efficiency, reduced inventory levels (less need for WIP), and improved responsiveness to customer demand, making SMED a valuable strategy for optimizing manufacturing processes.
    /// </summary>
    SingleMinuteExchangeOfDie,
    /// <summary>
    /// Arrival Time refers to the time at which a flow unit or item arrives at a specific stage or point in a process or supply chain.
    /// </summary>
    ArrivalTime,
    /// <summary>
    /// Interarrival Time refers to the time interval between the arrivals of consecutive flow units or items at a specific stage or point in a process or supply chain.
    /// </summary>
    InterarrivalTime,
    /// <summary>
    /// Throughput Loss refers to the reduction in the flow rate or output of a process due to inefficiencies, bottlenecks, or other factors that limit the capacity of the process.
    /// </summary>
    ThroughputLoss,
    /// <summary>
    /// The buffer or suffer principle is a concept in supply chain management that emphasizes the importance of maintaining sufficient inventory or buffer stock to absorb fluctuations in demand and prevent disruptions in the flow of materials or products.
    /// If a process or supply chain operates without adequate buffers, it may suffer from delays, stockouts, or other inefficiencies that can negatively impact performance and customer satisfaction.
    /// </summary>
    BufferOrSufferPrinciple,
    /// <summary>
    /// Customers abandon queue 
    /// </summary>
    CustomersAbandonQueue,
    /// <summary>
    /// Resource blocked refers to a situation where a resource, such as a machine, worker, or process, is unable to proceed with its tasks or operations due to specific conditions or constraints that prevent it from functioning effectively.
    /// </summary>
    ResourceBlocked,
    /// <summary>
    /// Resource starved refers to a situation where a resource, such as a machine, worker, or process, is unable to proceed with its tasks or operations due to a lack of necessary inputs or conditions.
    /// </summary>
    ResourceStarved,
    /// <summary>
    /// Horizontal pooling refers to the practice of sharing resources, such as labor, equipment, or inventory, across multiple processes or stages within a supply chain or production system.
    /// This approach can help optimize resource utilization, reduce costs, and improve overall efficiency by leveraging available resources more effectively.
    /// Similar to the concept of "shared resources" or "cross-functional resource allocation," horizontal pooling allows for greater flexibility and responsiveness in managing fluctuations in demand and capacity across different parts of the supply chain.
    /// Similar to the concept of work cell, horizontal pooling can help to balance workloads and reduce bottlenecks by allowing resources to be allocated dynamically based on demand and capacity needs across the entire system.
    /// </summary>
    HorizontalPooling
}
