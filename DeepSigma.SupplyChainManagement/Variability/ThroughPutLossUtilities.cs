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


}
