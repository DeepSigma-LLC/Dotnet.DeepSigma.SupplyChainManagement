namespace DeepSigma.SupplyChainManagement;

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
    IshikawaDiagram,
    /// <summary>
    /// Five whys is a problem-solving technique used to explore the cause-and-effect relationships underlying a particular problem or issue.
    /// By repeatedly asking the question "Why?" (typically five times), the technique helps to drill down into the root cause of a problem, allowing teams to identify and address the underlying issues rather than just treating the symptoms.
    /// This method is often used in quality management and process improvement to facilitate deeper analysis and more effective problem-solving, ultimately leading to more sustainable solutions.
    /// </summary>
    FiveWhys,
    /// <summary>
    /// Pareto diagram, also known as a Pareto chart, is a graphical tool used to prioritize and analyze the relative importance of different factors or causes contributing to a problem or effect.
    /// Pareto diagrams are based on the Pareto principle, which states that roughly 80% of the effects come from 20% of the causes.
    /// It is commonly used in quality management and process improvement to prioritize actions and focus on the most impactful issues.
    /// By charting the frequency or impact of different factors, Pareto Analysis helps teams to identify the "vital few" causes that contribute the most to a problem, allowing for more targeted and effective interventions to improve quality and performance.
    /// </summary>
    ParetoDiagram,
    /// <summary>
    /// The Pareto principle, also known as the 80/20 rule, is a principle that states that roughly 80% of the effects come from 20% of the causes.
    /// In the context of quality management and process improvement, the Pareto principle suggests that a small number of causes or factors are responsible for the majority of problems or effects in a process or system.
    /// </summary>
    ParetoPrinciple,
    /// <summary>
    /// Statistic Process Control (SPC) is a method of quality control that uses statistical techniques to monitor and control a process, ensuring that it operates at its full potential to produce conforming products with minimal waste.
    /// SPC involves collecting and analyzing data from the production process to identify variations and trends, allowing for early detection of potential issues and enabling proactive measures to maintain process stability and improve quality.
    /// </summary>
    StatisticProcessControl,
    /// <summary>
    /// Upper Specification Limit (USL) is the maximum acceptable value for a process or product characteristic.
    /// Often used in Capability Analysis, it represents the upper threshold that defines the acceptable range of variation for a specific characteristic or parameter in a process or product.
    /// </summary>
    UpperSpecificationLimit,
    /// <summary>
    /// Lower Specification Limit (LSL) is the minimum acceptable value for a process or product characteristic.
    /// Often used in Capability Analysis, it represents the lower threshold that defines the acceptable range of variation for a specific characteristic or parameter in a process or product.
    /// </summary>
    LowerSpecificationLimit,
    /// <summary>
    /// Defect Probability is the likelihood of a defect occurring in a process or product.
    /// </summary>
    DefectProbability,
    /// <summary>
    /// Process Capability Index (Cpk) is a statistical measure of a process's ability to produce output within specified limits.
    /// It considers both the process mean (or specification limits) and variability, providing a more comprehensive assessment of process performance compared to Cp.
    /// </summary>
    ProcessCapabilityIndex,
    /// <summary>
    /// Six Sigma is a set of techniques and tools for process improvement, aiming to reduce defects and variability in processes.
    /// </summary>
    SixSigma,
    /// <summary>
    /// Parts Per Million (PPM) is a common unit of measurement used to express the number of defective units in a million units produced.
    /// Since quality control often wants very low defect rates, PPM is a more practical way to express the level of defects in a process, especially when dealing with high-quality processes where the defect rate is very low.
    /// </summary>
    PartsPerMillion,
    /// <summary>
    /// Capability Analysis is a statistical method used to assess how well a process can produce output that meets specifications.
    /// It involves evaluating the process performance against predefined criteria to determine its ability to consistently produce products within the desired specifications.
    /// </summary>
    CapabilityAnalysis,
    /// <summary>
    /// Capability Index is a numerical measure of a process's ability to produce output within specified limits.
    /// </summary>
    CapabilityIndex,
    /// <summary>
    /// Conformity Analysis is a method used to determine whether a product or process meets specified standards or requirements.
    /// It involves comparing the characteristics of the product or process against predefined criteria to assess whether it conforms to the desired specifications, ensuring that quality standards are met and maintained throughout production.
    /// </summary>
    ConformityAnalysis,
    /// <summary>
    /// Control Chart is a graphical tool used to monitor and control a process by plotting data points over time and identifying any variations or trends that may indicate a problem.
    /// It helps in distinguishing between common cause variation (inherent to the process) and special cause variation (due to specific factors), enabling timely corrective actions.
    /// </summary>
    ControlChart,
    /// <summary>
    /// Upper Control Limit (UCL) is the upper threshold on a control chart that indicates the maximum acceptable level of variation in a process before it is considered out of control.
    /// Typically used in Conformity Analysis, it helps to identify when a process is producing output that exceeds the expected range of variation, signaling the need for investigation and corrective action to maintain process stability and quality.
    /// </summary>
    UpperControlLimit,
    /// <summary>
    /// Lower Control Limit (LCL) is the lower threshold on a control chart that indicates the minimum acceptable level of variation in a process before it is considered out of control.
    /// Typically used in Conformity Analysis, it helps to identify when a process is producing output that falls below the expected range of variation, signaling the need for investigation and corrective action to maintain process stability and quality.
    /// </summary>
    LowerControlLimit,
    /// <summary>
    /// p-chart is a type of control chart used to monitor the proportion of defective items in a process over time.
    /// It is commonly used in quality control to track the percentage of non-conforming units in a sample, allowing for the identification of trends and variations in the defect rate, and enabling timely interventions to improve process performance and maintain quality standards.
    /// It is similar to the concept of a control chart, but specifically designed for tracking proportions or percentages of defects in a process, making it a valuable tool for monitoring and improving quality in manufacturing and other industries.
    /// Our center of attention is on the proportion (aka percentage) of defective items in a process, hence the "p" in "p-chart."
    /// The UCL and LCL in a p-chart are calculated based on the average proportion of defects and the sample size, allowing for the identification of significant deviations from the expected defect rate and facilitating proactive quality management.
    /// </summary>
    PChart,
    /// <summary>
    /// Defect refers to a flaw, imperfection, or non-conformity in a product, process, or system that deviates from specified requirements or standards.
    /// </summary>
    Defect,
    /// <summary>
    /// Rework refers to the process of correcting or fixing a defect in a product, process, or system to bring it back into compliance with specified requirements or standards.
    /// </summary>
    Rework,
    /// <summary>
    /// Resource yield refers to the amount of usable output or value that can be obtained from a given resource, such as labor, materials, or equipment, in a production process or supply chain.
    /// It is a measure of the efficiency and effectiveness of resource utilization, indicating how much value or output can be generated from the resources invested in a process.
    /// For example, if a machine has a resource yield of 80%, it means that 80% of the input materials or labor invested in that machine results in usable output, while the remaining 20% may be lost due to inefficiencies, defects, or other factors.
    /// </summary>
    ResourceYield,
    /// <summary>
    /// Process yield is similar to resource yield but focuses on the overall output of a process rather than individual resources. It refers to the percentage of products or units that are produced without defects or rework, indicating the efficiency and effectiveness of the entire production process.
    /// It is calculated by dividing the number of good units produced by the total number of units that entered the process, and it serves as a key performance indicator for assessing the quality and efficiency of a production process.
    /// </summary>
    ProcessYield,
    /// <summary>
    /// Quality at the source refers to the practice of ensuring that quality is built into every stage of the production process, starting from the initial stages of design and development, through manufacturing and assembly, and all the way to the final product.
    /// This approach emphasizes the importance of preventing defects and ensuring quality at every step of the process, rather than relying solely on inspection and testing at the end of the production line.
    /// This concept is closely related to the idea of built-in quality control, where processes and systems are designed to prevent errors and defects from occurring in the first place, rather than just identifying and addressing them after they have occurred.
    /// Finding defects at the source allows for immediate corrective action, preventing the production of defective products and maintaining high standards of quality throughout the manufacturing process.
    /// It is also usually easy to spot and fix defects at the source, since the process is still fresh in the minds of workers and managers, and the necessary resources and information are readily available to address any issues that arise.
    /// </summary>
    QualityAtTheSource,


    /// <summary>
    /// Customer Value Curve is a visual representation of the different factors that customers consider when making purchasing decisions and how a company can differentiate itself from competitors by offering unique value in those areas.
    /// </summary>
    CustomerValueCurve,
    /// <summary>
    /// Demand aggregation refers to the process of combining customer demand from multiple sources or locations to achieve economies of scale, reduce costs, and improve efficiency in production and distribution.
    /// </summary>
    DemandAggregation,
    /// <summary>
    /// Statistical economies of scale refer to the idea the variability in demand can be reduced by aggregating demand across multiple customers, products, or locations, leading to more efficient production and distribution processes.
    /// </summary>
    StatisticalEconomiesOfScale,
    /// <summary>
    /// DuPont Model is a financial analysis framework that breaks down return on equity (ROE) into its component parts, allowing for a more detailed understanding of the factors that contribute to a company's profitability and financial performance.
    /// The DuPont Model typically decomposes ROE into three main components: profit margin, asset turnover, and financial leverage. 
    /// By analyzing these components separately, businesses can identify areas of strength and weakness in their operations and make informed decisions to improve overall performance and create value for shareholders.
    /// </summary>
    DuPontModel,
    /// <summary>
    /// Revenue management refers to the strategic approach of optimizing a company's revenue by analyzing and managing various factors that influence pricing, demand, and customer behavior.
    /// Also, known as yield management, it involves using data and analytics to make informed decisions about pricing, inventory management, and customer segmentation to maximize revenue and profitability.
    /// </summary>
    RevenueManagement,
    /// <summary>
    /// Overbooking is a common practice in industries such as airlines, hotels, and event management, where companies sell more tickets or reservations than the actual capacity of their services, anticipating that some customers will cancel or not show up.
    /// While overbooking can help to maximize revenue and reduce the impact of no-shows, it can also lead to customer dissatisfaction and logistical challenges if more customers show up than expected, requiring companies to manage the situation carefully to minimize negative impacts on customer experience and brand reputation.
    /// </summary>
    Overbooking,
    /// <summary>
    ///  Booking limits in the context of revenue management and overbooking refers to the practice of setting limits on the number of reservations or bookings that can be accepted for a particular service or product, based on factors such as historical demand patterns, customer behavior, and capacity constraints.
    ///  This ensure that the company reserves enough capacity to accommodate expected demand while minimizing the risk of overbooking and its associated challenges, such as customer dissatisfaction and logistical issues.
    /// </summary>
    BookingLimits,

    /// <summary>
    /// Bullwhip effect refers to the phenomenon where small fluctuations in demand at the consumer level can lead to increasingly larger fluctuations in demand at the wholesale, distributor, manufacturer, and raw material supplier levels in a supply chain.
    /// This effect can lead to inefficiencies, such as excess inventory, stockouts, and increased costs, as each level of the supply chain reacts to perceived changes in demand without accurate information about actual consumer demand.
    /// The bullwhip effect is often caused by factors such as demand forecasting errors, order batching, price fluctuations, and lack of communication and coordination among supply chain partners.
    /// </summary>
    BullwhipEffect,
    /// <summary>
    /// Incentive conflict refers to a situation where the incentives or motivations of different parties in a supply chain or business relationship are not aligned, leading to potential conflicts of interest and suboptimal outcomes for one or more parties involved.
    /// Conflicts can arise in various contexts, such as between suppliers and manufacturers, between employers and employees, or between different departments within an organization, and can lead to issues such as reduced cooperation, inefficiencies, and decreased overall performance if not properly managed and addressed.
    /// </summary>
    IncentiveConflict,
    /// <summary>
    /// Incentive alignment refers to the process of designing and implementing incentives, such as compensation structures, performance metrics, and reward systems, in a way that encourages and motivates individuals or groups to work towards common goals and objectives.
    /// Aligning incentives can help to foster collaboration, improve performance, and achieve better outcomes for all parties involved by ensuring that everyone is working towards the same objectives and is motivated to contribute to the success of the organization or supply chain.
    /// </summary>
    IncentiveAlignment,
    /// <summary>
    /// Trade promotion refers to marketing activities and incentives offered by manufacturers or suppliers to retailers or distributors to encourage them to promote and sell their products.
    /// </summary>
    TradePromotion,
    /// <summary>
    /// Forward buying refers to the practice of purchasing larger quantities of products than needed in the short term, often in response to promotions or anticipated price increases.
    /// </summary>
    ForwardBuying,
    /// <summary>
    /// Channel stuffing refers to the practice of deliberately sending more products to distributors or retailers than they can sell in a given period, often to inflate sales figures or meet sales targets.
    /// </summary>
    ChannelStuffing,
    /// <summary>
    /// Diversion refers to the unauthorized or unintended redirection of products from their intended distribution channels, often resulting in products being sold in markets or regions where they were not originally intended to be sold.
    /// This can occur due to various reasons, such as price differences between markets, supply chain disruptions, or intentional actions by intermediaries, and can lead to issues such as brand dilution, loss of revenue, and challenges in managing inventory and demand across different markets.
    /// </summary>
    Diversion
}
