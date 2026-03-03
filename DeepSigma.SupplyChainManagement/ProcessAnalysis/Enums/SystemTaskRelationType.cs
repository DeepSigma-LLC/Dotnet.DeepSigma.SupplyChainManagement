namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// SystemTaskRelationType specifies the type of relationship between tasks within a system, particularly in the context of process design, workflow management, or project planning.
/// </summary>
public enum SystemTaskRelationType
{
    /// <summary>
    /// Atomic refers to a task that is indivisible (cannot be broken down into smaller components), or one that must be completed in its entirety before any subsequent tasks can begin.
    /// </summary>
    Atomic,
    /// <summary>
    /// Coupled tasks are those that are closely linked or interdependent, meaning that the completion of one task directly affects the execution or outcome of another task.
    /// </summary>
    Coupled,
}
