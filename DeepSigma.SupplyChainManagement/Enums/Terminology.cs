
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
    HorizontalPooling,
    /// <summary>
    /// Lean operations is a systematic approach to identifying and eliminating waste in a process or supply chain, with the goal of improving efficiency, reducing costs, and enhancing customer value.
    /// It originated from the Toyota Production System (TPS) and has been widely adopted across various industries as a methodology for optimizing operations and achieving continuous improvement.
    /// Lean operations focuses on streamlining processes, minimizing inventory, reducing lead times, and maximizing value for customers by eliminating non-value-added activities and optimizing the flow of materials and information throughout the supply chain.
    /// </summary>
    LeanOperations,
    /// <summary>
    /// Just-in-Time (JIT) production is a manufacturing strategy that aims to minimize inventory and reduce waste by producing and delivering products or components only when they are needed in the production process or by customers.
    /// Flow units are produced or procured just in time to meet demand, which helps to reduce holding costs, improve cash flow, and increase responsiveness to customer needs.
    /// </summary>
    JustInTimeProduction,
    /// <summary>
    /// Kanban is an inventory control system used in just-in-time (JIT) manufacturing. 
    /// It was developed by Taiichi Ohno, an industrial engineer at Toyota, and takes its name from the colored cards that track production and order new shipments of parts or materials as they run out. 
    /// Kanban is a Japanese word that directly translates to "visual card," so the kanban system simply means to use visual cues to prompt the action needed to keep a process flowing.
    /// The kanban system can be thought of as a signal and response system. When an item is running low at an operational station, there will be a visual cue specifying how much to order from the supply.
    /// </summary>
    /// <remarks>
    /// For example, if a worker is bagging product on a conveyor belt, a kanban may be placed in the stack above the last 10 bags. 
    /// When the worker gets to the card, he gives the floor runner the card to bring more bags. 
    /// A station further from the supply room might have the kanban placed at 15 bags and a closer one at five. 
    /// The flow of bags and the placement of cards are adjusted to make sure no station is left bag-less while the belt is running.
    /// </remarks>
    Kanban,
    /// <summary>
    /// Kanban board is a visual tool used in project management and lean manufacturing to visualize work, limit work in progress, and optimize the flow of tasks or items through a process.
    /// It typically consists of columns representing different stages of the workflow (e.g., To Do, In Progress, Done) and cards or sticky notes representing individual tasks or items that move through the columns as they progress through the process.
    /// </summary>
    /// <remarks>
    /// It originated from the kanban system used in just-in-time (JIT) manufacturing where a kanban is a visual signal (usually a physcial card) strategically placed to trigger action at a certain point in the production process, 
    /// and has been widely adopted in various industries as a method for managing work and improving efficiency.
    /// </remarks>
    KanbanBoard,
    /// <summary>
    /// Takt Time is a measure of the time it takes to produce one unit of output in a production process, based on the rate of customer demand.
    /// "Takt" is a German word that translates to "beat" or "rhythm," and it represents the pace at which products need to be produced to meet customer demand.
    /// Takt Time is calculated by dividing the available production time by the customer demand for a specific period, and it serves as a critical metric for synchronizing production processes and ensuring that they are aligned with customer needs.
    /// This computation is similar to the concept of demand rate, which is the rate at which customers require products or services.
    /// </summary>
    TaktTime,
    /// <summary>
    /// MRP (Material Requirements Planning) system is a production planning and inventory control system that helps manufacturers manage their production processes and inventory levels by calculating the materials and components needed to meet production schedules.
    /// </summary>
    MRPSystem,
    /// <summary>
    /// ERP (Enterprise Resource Planning) system is an integrated software platform used by organizations to manage and automate core business processes, including finance, human resources, supply chain, manufacturing, and other operations.
    /// </summary>
    ERPSystem,
    /// <summary>
    /// Push system is a production strategy where production is usually initiated based on forecasted demand, and goods are produced and moved through the supply chain according to a predetermined schedule.
    /// In a push system, flow units are allowed to enter the process independent of the current amount of inventory in process. 
    /// Push systems can lead to overproduction and excess inventory if forecasts are inaccurate, but they allow for better control over production processes and can be more efficient in certain scenarios where demand is relatively stable.
    /// </summary>
    PushSystem,
    /// <summary>
    /// Fill-up pull system is a production strategy where production is initiated based on actual demand, and the system is designed to fill up inventory levels to meet that demand.
    /// The upsteam processes produces goods to replenish what demand has consumed down stream.
    /// This approach helps to minimize inventory levels and reduce waste, while ensuring that products are available to meet customer demand in a timely manner.
    /// </summary>
    FillUpPullSystem,
    /// <summary>
    /// Make-to-order pull system is a production strategy where production is initiated only after receiving a customer order, ensuring that products are made to meet specific customer requirements.
    /// This approach helps to minimize inventory levels and reduce waste, while providing customized products to customers.
    /// </summary>
    MakeToOrderPullSystem,
    /// <summary>
    /// Poka-yoke is a Japanese term that translates to "mistake-proofing" or "error-proofing." 
    /// It refers to any mechanism or device that helps to prevent errors or defects in a process by making it impossible for mistakes to occur or by providing immediate feedback when an error is made.
    /// </summary>
    PokaYoke,
    /// <summary>
    /// Jidoka is a Japanese term that translates to "automation with a human touch" or "autonomation." 
    /// It refers to the concept of designing equipment and processes to automatically detect and respond to abnormalities or defects, allowing human operators to focus on value-added tasks and ensuring that quality issues are addressed immediately.
    /// Jidoka is a key principle of the Toyota Production System (TPS) and is often implemented through the use of sensors, alarms, and other mechanisms that can identify problems in real-time and trigger appropriate responses, such as stopping production or alerting operators to take corrective action.
    /// </summary>
    Jidoka,
    /// <summary>
    /// Andon cord is a version of Jidoka that allows workers to pull a cord or press a button to immediately stop the production line when they identify a problem or defect.
    /// This empowers workers to take ownership of quality and ensures that issues are addressed promptly, preventing the production of defective products and maintaining high standards of quality throughout the manufacturing process.
    /// </summary>
    AndonCord,
    /// <summary>
    /// Built-in quality control refers to the practice of designing processes and systems in such a way that quality is built into every stage of production, rather than relying solely on inspection and testing at the end of the process.
    /// This approach helps to prevent defects, reduce waste, and ensure that products meet quality standards consistently.
    /// If a problem arises during production, waiting until the end of the process to identify and address it can lead to significant waste and inefficiencies since the defect may be present in the entire batch of products (every flow unit in the WIP). 
    /// By incorporating built-in quality control measures, such as error-proofing (poka-yoke) and real-time monitoring (jidoka), manufacturers can identify and address issues immediately, preventing the production of defective products and maintaining high standards of quality throughout the manufacturing process.
    /// </summary>
    BuiltInQualityControl,
    /// <summary>
    /// Information turnaround time refers to the time it takes for information to be processed, transmitted, and received within a system or supply chain.
    /// Often used in the context of quality control and decision-making processes, information turnaround time indicates how quickly information can be gathered, analyzed, and acted upon to address issues or make informed decisions.
    /// For example, the time between creating a defect and receiving the feedback about the defect.
    /// Large buffer sizes can lead to longer information turnaround times, as it may take more time for information on each flow unit in the WIP to be processed and transmitted through the system.
    /// </summary>
    InformationTurnaroundTime,
    /// <summary>
    /// Inventory reduction technique refers to strategies and methods used to minimize inventory levels while maintaining efficient operations and meeting customer demand.
    /// This can include techniques such as just-in-time (JIT) production, kanban systems, demand forecasting, and supply chain optimization to reduce excess inventory, minimize holding costs, and improve overall efficiency in the supply chain.
    /// Reducing inventory can help to free up capital, reduce storage costs, and improve cash flow, but it requires careful planning and coordination to ensure that customer demand is still met without causing stockouts or disruptions in the production process.
    /// </summary>
    /// <remarks>
    /// The use of the kanban system, for example, is a common inventory reduction technique that helps to control the flow of materials and products through the supply chain, ensuring that inventory levels are kept at optimal levels based on actual demand.
    /// The kanban system enables managers to systematically reduce inventory levels when needed, thus identifying bottlenecks and processing inefficiencies that may be hidden by large inventory levels.
    /// Those bottlenecks and inefficiencies can be addressed to improve flow rate and reduce lead times, ultimately leading to a more efficient and responsive supply chain. 
    /// Then the kanban system can be used again to further reduce inventory levels, creating a continuous cycle of improvement and optimization in the supply chain.
    /// This system enables managers to choose when the exact time to focus on process improvement. 
    /// Perhaps when demands slows down, or when the company is looking to cut costs, or when the company is looking to improve cash flow.
    /// </remarks>
    InventoryReductionTechnique,
    /// <summary>
    /// Shared resource refers to a resource, such as labor, equipment, or inventory, that is utilized across multiple processes or stages within a supply chain or production system.
    /// </summary>
    SharedResource,
    /// <summary>
    /// Chaining (or partial flexibility) in supply chain management links production facilities to specific subsets of products, allowing plants to handle overflow from others. 
    /// This cost-effective strategy provides 80–90% of the benefits of full flexibility by reducing inventory costs and managing demand uncertainty without the high expense of making every plant capable of producing all products.
    /// </summary>
    PartialFlexibility,
    /// <summary>
    /// Quality Circle is a group of workers who meet regularly to discuss and solve problems related to quality and productivity in their work area.
    /// </summary>
    QualityCircle,
    /// <summary>
    /// Ishikawa diagram, also known as a fishbone diagram or cause-and-effect diagram, is a visual tool used to systematically identify and analyze the potential causes of a specific problem or effect.
    /// It is commonly used in quality management and process improvement to help teams brainstorm and categorize the various factors that may contribute to a problem, allowing for a structured approach to problem-solving and root cause analysis.
    /// </summary>
    IshikawaDiagram
}
