
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// ProcessScalingApproach specifies the 3 primary strategies for scaling a process.
/// </summary>
public enum ProcessScalingApproach
{
    /// <summary>
    /// Replicates an existing process line, creating a new instance with the same configuration.
    /// </summary>
    /// <remarks>Use this member to duplicate a process line when you need to preserve its settings or
    /// structure. The replication does not affect the original process line.</remarks>
    ReplicateExistingProcessLine,
    /// <summary>
    /// Scales specific stages of a process based on provided criteria or configuration.
    /// Usually involves identifying bottlenecks (highest implied utilitization) or critical stages (increase redundency and robustness) and applying targeted improvements to increase capacity or efficiency at those points, rather than replicating the entire process line.
    /// </summary>
    SelectivelyScaleProcessStages,
    /// <summary>
    /// Increases the capacity of a process by leveraging specialization, such as implementing automation, optimizing workflows, or enhancing specific skills or resources to improve efficiency and throughput without necessarily replicating the entire process line.
    /// Often to better use existing / future resources we line balance the process.
    /// This can be accomplished by decreasing the span of control for workers by assigning them to smaller, more specialized tasks, which can increase efficiency and throughput by allowing workers to focus on specific activities that match their skills and expertise, rather than performing a wide range of tasks that may lead to inefficiencies and bottlenecks in the process.
    /// </summary>
    IncreaseProcessCapacityBySpecialization,
}
