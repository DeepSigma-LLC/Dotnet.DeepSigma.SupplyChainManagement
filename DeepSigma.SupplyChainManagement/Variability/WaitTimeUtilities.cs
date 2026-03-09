using DeepSigma.General.Extensions;

namespace DeepSigma.SupplyChainManagement.Variability;

/// <summary>
/// WaitTimeUtilities provides methods for calculating the approximate wait time in a production process based on various factors such as utilization, number of servers, process time, and coefficients of variation for interarrival times and process times. These calculations can help in understanding and managing variability in production processes, allowing for better scheduling, resource allocation, and overall performance optimization.
/// </summary>
public static class WaitTimeUtilities
{
    /// <summary>
    /// ComputeApproximateWaitTime calculates the approximate wait time in a production process based on the utilization, number of servers, process time, and coefficients of variation for interarrival times and process times.
    /// For the case where there is only one server and the process times are exponentially distributed, the formula simplifies to Wq = (utilization * process_time) / (1 - utilization), which is derived from the M/M/1 queueing model.
    /// In this situation, the wait time is no longer an approximation but an exact calculation, as the M/M/1 model provides a precise solution for the average wait time in the queue when there is a single server and exponential service times.
    /// </summary>
    /// <param name="utilization"></param>
    /// <param name="number_of_servers"></param>
    /// <param name="process_time"></param>
    /// <param name="coefficient_of_variation_of_interarrival_times"></param>
    /// <param name="coefficient_of_variation_of_process_times"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static decimal ComputeApproximateWaitTime(decimal utilization, int number_of_servers, decimal process_time, decimal coefficient_of_variation_of_interarrival_times, decimal coefficient_of_variation_of_process_times)
    {
        if (number_of_servers <= 0)
            throw new ArgumentOutOfRangeException(nameof(number_of_servers), "Number of servers must be greater than zero.");
        if (process_time < 0)
            throw new ArgumentOutOfRangeException(nameof(process_time), "Process time must be non-negative.");
        if (utilization < 0 || utilization >= 1)
            throw new ArgumentOutOfRangeException(nameof(utilization), "Utilization must be between 0 and 1 (exclusive).");
        if (coefficient_of_variation_of_interarrival_times < 0)
            throw new ArgumentOutOfRangeException(nameof(coefficient_of_variation_of_interarrival_times), "Coefficient of variation of interarrival times must be non-negative.");
        if (coefficient_of_variation_of_process_times < 0)
            throw new ArgumentOutOfRangeException(nameof(coefficient_of_variation_of_process_times), "Coefficient of variation of process times must be non-negative.");

        decimal system_variability = Math.Pow(coefficient_of_variation_of_interarrival_times, 2) + Math.Pow(coefficient_of_variation_of_process_times, 2);
        decimal utilization_factor = utilization / (1 - utilization);
        decimal average_process_time = process_time / number_of_servers;

        decimal approximate_wait_time = average_process_time * utilization_factor* system_variability;
        return approximate_wait_time;
    }
}
