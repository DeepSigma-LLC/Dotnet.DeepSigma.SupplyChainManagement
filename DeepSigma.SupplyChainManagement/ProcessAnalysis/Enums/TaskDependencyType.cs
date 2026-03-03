namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Specifies the type of dependency relationship between tasks.
/// </summary>
public enum TaskDependencyType
{
    /// <summary>
    /// Dependent tasks are those that rely on the completion of other tasks before they can begin. These tasks cannot start until their prerequisite tasks have been completed, creating a sequential flow of work. 
    /// For example, in a manufacturing process, the assembly of a product may be dependent on the completion of the component manufacturing tasks.
    /// </summary>
    Dependent,
    /// <summary>
    /// Independent tasks are those that can be performed without relying on the completion of other tasks. 
    /// These tasks can be executed in parallel or at any time, as they do not have any prerequisites or dependencies on other tasks.
    /// </summary>
    Independent,
    /// <summary>
    /// Interdependent tasks are those that have a mutual dependency relationship, meaning that they rely on each other for completion.
    /// In this case, the tasks are interconnected and may require coordination or synchronization to ensure that they can be completed successfully.
    /// </summary>
    Interdependent,
}
