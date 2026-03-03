namespace DeepSigma.SupplyChainManagement.Variability.Enums;

/// <summary>
/// Defines the sources of variation that can affect a process, distinguishing between common cause variation and
/// assignable cause variation.
/// </summary>
/// <remarks>Common cause variation represents inherent variability in a process that cannot be easily controlled,
/// while assignable cause variation can be traced to specific, identifiable sources. Understanding these variations is
/// crucial for effective process management and improvement.</remarks>
public enum SourcesOfVariation
{
    /// <summary>
    /// Common cause variation refers to the inherent variability that is present in any process or system due to factors that are always present and cannot be easily identified or controlled.
    /// It is also known as "natural variation" or "systemic variation" and is considered a normal part of the process.
    /// It is impossible to eliminate common cause variation completely, but it can be reduced through process improvements and better control measures.
    /// This type of variation is also difficult to predict although it can be measured and monitored using statistical process control (SPC) techniques to identify trends and patterns in the data.
    /// </summary>
    CommonCauseVariation,
    /// <summary>
    /// Assignable cause variation refers to variability in a process that can be traced to a specific, identifiable source or cause.
    /// This type of variation is easily identifiable and can be attributed to specific factors such as equipment malfunctions, operator errors, or changes in raw materials.
    /// It is possible to eliminate or reduce assignable cause variation by identifying and addressing the root causes.
    /// Also, building more robust processes can help to minimize the impact of assignable cause variation and prevent it from occurring in the future.
    /// For example, designing parts that only fit together in the correct way can help to prevent assembly errors and reduce assignable cause variation in the manufacturing process.
    /// Or syringes that only fit with the correct medication can help to prevent medication errors and reduce assignable cause variation in healthcare settings.
    /// </summary>
    AssignableCauseVariation
}
