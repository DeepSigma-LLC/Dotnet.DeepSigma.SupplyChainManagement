
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// Statistical Process Control (SPC) is a method of quality control that uses statistical methods to monitor and control a process. 
/// The steps in SPC include Capability, Conformance, Investigation of assignable cause, and Elimination of assignable cause. 
/// Each step plays a crucial role in ensuring that the process operates efficiently, produces high-quality output, and minimizes variations.
/// </summary>
public enum StatisticalProcessControlStep
{
    /// <summary>
    /// Capability analysis involves assessing the ability of a process to produce output that meets specifications. 
    /// This step typically includes calculating process capability indices (such as Cp, Cpk) to determine how well the process can produce within specified limits.
    /// </summary>
    CapabilityAnalysis,
    /// <summary>
    /// Conformance analysis involves evaluating whether a process or product meets specified requirements or standards. 
    /// This step ensures that the output adheres to predefined criteria, maintaining quality and consistency.
    /// </summary>
    ConformanceAnalysis,
    /// <summary>
    /// Investigation of assignable cause involves identifying specific factors or events that lead to variations in a process. This step aims to determine the root cause of deviations from expected performance.
    /// </summary>
    InvestigationOfAssignableCause,
    /// <summary>
    /// Elimination of assignable cause involves taking corrective actions to remove or mitigate the identified factors or events that cause variations in a process. This step aims to improve process stability and performance.
    /// </summary>
    EliminationOfAssignableCause
}
