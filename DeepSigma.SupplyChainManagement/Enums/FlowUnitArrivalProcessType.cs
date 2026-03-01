
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// Specifies the types of flow unit arrival processes used to model how flow units enter a system over time.
/// </summary>
/// <remarks>This enumeration distinguishes between uniform, stationary, and non-stationary arrival processes,
/// each representing different patterns of flow unit arrivals. Selecting the appropriate arrival process type is
/// important for accurately modeling and analyzing system behavior in supply chain and operations contexts.</remarks>
public enum FlowUnitArrivalProcessType
{
    /// <summary>
    /// Uniform arrival processes are characterized by a constant inter-arrival time, meaning that flow units arrive at regular intervals.
    /// </summary>
    Uniform,
    /// <summary>
    /// Stationary arrival processes are characterized by a constant arrival rate, meaning that the average number of flow units arriving per unit of time remains constant over time.
    /// The difference between uniform and stationary arrival processes is that uniform arrival processes have a constant inter-arrival time, while stationary arrival processes have a constant arrival rate.
    /// </summary>
    Stationary,
    /// <summary>
    /// Non-stationary arrival processes are characterized by time-varying arrival rates, meaning that the rate at which flow units arrive changes over time.
    /// For example, a non-stationary arrival process may have a higher arrival rate during certain periods of the day or week, and a lower arrival rate during other periods.
    /// Another example of a non-stationary arrival process is one that experiences seasonal fluctuations, where the arrival rate increases during certain seasons and decreases during others.
    /// </summary>
    NonStationary
}
