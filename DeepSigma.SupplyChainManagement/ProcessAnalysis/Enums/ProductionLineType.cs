namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// ProductionLineType specifies the different types of production lines that can be used in manufacturing processes, each with its own characteristics and advantages depending on the nature of the products being produced, the volume of production, and the level of customization required.
/// </summary>
public enum ProductionLineType
{
    /// <summary>
    /// Job shop is a manufacturing process in which a variety of custom products are made.
    /// Often characterized by low volume and high variety, job shops typically produce products based on specific customer orders or unique specifications.
    /// Each product may require different processing steps and equipment, and the production is typically organized around individual workstations or machines. 
    /// Job shops are characterized by their flexibility and ability to handle a wide range of products, but they may have longer lead times and higher costs compared to other manufacturing processes.
    /// </summary>
    JobShop,
    /// <summary>
    /// Batch processing is a manufacturing process in which a group of similar products are produced together in a single production run. 
    /// The products are processed in batches, and each batch goes through the same set of processing steps before moving on to the next batch.
    /// </summary>
    BatchProcess,
    /// <summary>
    /// Worker paced line is a manufacturing process in which workers are responsible for controlling the pace of production.
    /// In this type of process, workers perform specific tasks at their own pace, and the production flow is determined by the speed at which they work.
    /// This type of process is often used in industries where the production tasks are complex and require a high level of skill, such as in assembly lines or manual labor-intensive processes.
    /// </summary>
    WorkerPacedLine,
    /// <summary>
    /// Machine paced line is a manufacturing process in which the pace of production is controlled by machines.
    /// In this type of process, machines determine the speed at which products are produced, and workers must keep up with the machine's pace.
    /// This type of process is often used in industries where high production rates and consistency are important, such as in automotive assembly lines or electronics manufacturing.
    /// </summary>
    MachinePacedLine,
    /// <summary>
    /// Continuous process is a manufacturing process in which the production runs continuously without interruption.
    /// This type of process is often used in industries where large volumes of products are produced, such as in chemical manufacturing or oil refining.
    /// </summary>
    ContinuousProcess
}
