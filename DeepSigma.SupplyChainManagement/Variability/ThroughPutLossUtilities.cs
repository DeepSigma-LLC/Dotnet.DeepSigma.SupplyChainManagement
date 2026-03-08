using DeepSigma.General.Extensions;
using System.Threading.Channels;

namespace DeepSigma.SupplyChainManagement.Variability;

internal class ThroughPutLossUtilities
{
    /// <summary>
    /// Calculates the probability that all resources are busy in a system modeled by the Erlang loss formula.
    /// </summary>
    /// <remarks>This method implements the Erlang B formula, commonly used in queueing theory to estimate
    /// blocking probability in systems without waiting queues. The result can be used to assess system capacity and
    /// performance under varying loads.</remarks>
    /// <param name="trafficIntensity">The average load on the system, expressed as traffic intensity. Must be greater than or equal to zero.
    /// For example, in a call center, traffic intensity can be calculated as the average number of calls per unit time multiplied by the average call duration. 
    /// In a manufacturing context, it can be calculated as the average number of jobs arriving per unit time multiplied by the average processing time per job. 
    /// The traffic intensity provides insight into how heavily the system is being utilized and helps determine the likelihood of blocking or congestion in the system.
    /// </param>
    /// <param name="numberOfServers">The number of available servers in the system. Must be greater than or equal to zero.</param>
    /// <returns>A decimal value between 0 and 1 representing the probability that all servers are busy and new arrivals are
    /// blocked.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="trafficIntensity"/> or <paramref name="numberOfServers"/> is less than zero.</exception>
    public static decimal ProbabilityAllResourcesAreBusyErlangLoss(decimal trafficIntensity, int numberOfServers)
    {
        if (trafficIntensity < 0)
            throw new ArgumentOutOfRangeException(nameof(trafficIntensity), "Traffic must be non-negative.");

        if (numberOfServers < 0)
            throw new ArgumentOutOfRangeException(nameof(numberOfServers), "Number of servers must be non-negative.");

        decimal b = 1.0m;

        for (int i = 1; i <= numberOfServers; i++)
        {
            b = (trafficIntensity * b) / (i + trafficIntensity * b);
        }

        return b;
    }

    /// <summary>
    /// Calculates the effective throughput of the system based on the probability that all buffers are full and the
    /// demand rate.
    /// </summary>
    /// <remarks>The throughput is determined by multiplying the demand rate by the probability that buffers
    /// are not full. If the probability that all buffers are full is 1, the throughput will be zero. If it is 0, the
    /// throughput equals the demand rate.</remarks>
    /// <param name="probability_that_all_buffers_are_full">The probability that all buffers in the system are full. Must be a value between 0 and 1, inclusive.</param>
    /// <param name="demand_rate">The expected number of requests per unit time for the system. Must be a non-negative value.</param>
    /// <returns>The calculated throughput of the system as a decimal value, representing the rate at which the system can
    /// process requests given the current buffer occupancy.</returns>
    public static decimal ComputeThroughputOfSystem(decimal probability_that_all_buffers_are_full, decimal demand_rate)
    {
        decimal probability_that_buffers_are_empty = probability_that_all_buffers_are_full.Complement();
        return probability_that_buffers_are_empty * demand_rate;
    }

}
