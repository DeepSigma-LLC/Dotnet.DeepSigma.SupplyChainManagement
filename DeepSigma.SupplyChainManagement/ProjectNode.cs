
namespace DeepSigma.SupplyChainManagement;

public class ProjectNode
{
    internal DateTime? ProjectTargetCompletionDate { get; set; }
    internal DateTime EarliestStartTime { get; set; }
    internal TimeSpan ProjectDuration { get; set; }
    internal DateTime EarliestCompletionTime => EarliestStartTime + ProjectDuration;
    internal DateTime LatestStartTime { get; set; }
    internal DateTime LatestCompletionTime { get; set; }
    internal TimeSpan SlackTime => LatestStartTime - EarliestStartTime;

    /// <summary>
    /// Indicates whether the project is on the critical path, meaning that any delay in this project will directly impact the overall project completion time.
    /// Determined by checking if the slack time is zero, which implies that there is no flexibility in the schedule for this project and it must be completed on time to avoid delaying the entire project.
    /// </summary>
    internal bool IsCritical => SlackTime == TimeSpan.Zero;

    internal List<ProjectNode> Dependencies { get; set; } = [];

    /// <summary>
    /// Recursively computes the optimal project completion time based on the longest path through the dependency graph.
    /// Note: This method assumes that there are no circular dependencies in the graph. If circular dependencies exist, additional logic would be needed to handle them appropriately.
    /// </summary>
    /// <returns></returns>
    internal TimeSpan ComputeOptimalProjectCompletionTime()
    {
        if (Dependencies.Count == 0) return ProjectDuration;
        
        TimeSpan maxDependencyCompletionTime = TimeSpan.Zero;
        foreach (ProjectNode dependency in Dependencies)
        {
            TimeSpan dependencyCompletionTime = dependency.ComputeOptimalProjectCompletionTime();
            if (dependencyCompletionTime > maxDependencyCompletionTime)
            {
                maxDependencyCompletionTime = dependencyCompletionTime;
            }
        }
        return maxDependencyCompletionTime + ProjectDuration;
    }
}
