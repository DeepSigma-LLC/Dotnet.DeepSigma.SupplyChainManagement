

namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// VariablilityDependenceParadigm specifies the two primary paradigms for understanding the relationship between variabilities in a system: Independence and Dependence.
/// </summary>
public enum VariablilityDependenceParadigm
{
    /// <summary>
    /// Independence refers to a situation where the variability of one process or component does not affect the variability of another process or component.
    /// Note: Under this paradigm, variabilities are expected to be canceled out or balanced across the system, leading to a more stable and predictable overall performance.
    /// In the law of large numbers, the average of a large number of independent and identically distributed random variables will tend to converge to the expected value, which is a fundamental principle in probability theory and statistics.
    /// Hence, variance reduction is achieved through the aggregation of independent variabilities, as the fluctuations in one process are offset by the fluctuations in another process, leading to a more stable overall system performance.
    /// </summary>
    Independence,
    /// <summary>
    /// Dependence refers to a situation where the variability of one process or component directly influences the variability of another process or component.
    /// Note: Under this paradigm, variabilities are expected to be amplified or compounded across the system, leading to a more volatile and unpredictable overall performance.
    /// In the context of supply chain management, dependence can lead to the bullwhip effect, where small fluctuations in demand at the consumer level can cause increasingly larger fluctuations in demand at the wholesale, distributor, manufacturer, and raw material supplier levels.
    /// In the context of project management, variability of tasks on the critical path can significantly impact the overall project duration and completion time.
    /// Any variation on the critial path will directly affect the project completion time, as there is no slack or buffer time available to absorb any delays.
    /// This paradigm is inextricably linked to the concept of path dependence, which refers to the idea that the outcome of a process or system is heavily influenced by its historical path or sequence of events, rather than just the current state or conditions.
    /// In investing, you can relate this to the performance of portfolio insurance.
    /// </summary>
    Dependence,
    
}
