
namespace DeepSigma.SupplyChainManagement.Utilities;

/// <summary>
/// Qualitty control utilities provide methods for assessing and improving the quality of processes and products.
/// </summary>
public static class QualityControlUtilities
{
    /// <summary>
    /// The process capability index (Cp) is a measure of how well a process can produce output that meets specifications. 
    /// It is calculated as the ratio of the specification width (the difference between the upper and lower specification limits) to the process width (six times the process standard deviation). 
    /// A higher Cp value indicates a more capable process, while a Cp value less than 1 indicates that the process is not capable of producing output within specifications.
    /// </summary>
    /// <param name="upper_specification_limit"></param>
    /// <param name="lower_specification_limit"></param>
    /// <param name="process_standard_deviation"></param>
    /// <returns></returns>
    public static decimal ComputeProcessCapabilityIndex(decimal upper_specification_limit, decimal lower_specification_limit, decimal process_standard_deviation)
    {
        if (process_standard_deviation == 0) return decimal.MaxValue;
        return (upper_specification_limit - lower_specification_limit) / (6 * process_standard_deviation);
        // Note: The 6 in the denominator comes from the idea that 99.6% of values should be within 3 std of the mean.
        // Therefore, if the difference in the upper and lower specification limit is the same as the spread of 6 std (3 std x 2 tails of the distribution),
        // then we get a value of 1 for the Capability Index.
        // This is a mathematical trick to standardize the index so that a value of 1 corresponds to a process that is just capable of meeting specifications.
        // Other the other hand, values greater than 1 indicate a more capable process (specification range is greater than the variance) and values less than 1 indicate an incapable process (specification range is less than the variance).
    }

    /// <summary>
    /// The defect probability is the likelihood that a process will produce output that falls outside of the specified limits.
    /// This method assumes variation in the process output follows a normal distribution. 
    /// It calculates the probability of producing output above the upper specification limit and below the lower specification limit, and sums these probabilities to get the total defect probability.
    /// </summary>
    /// <param name="upper_specification_limit"></param>
    /// <param name="lower_specification_limit"></param>
    /// <param name="process_mean"></param>
    /// <param name="process_standard_deviation"></param>
    /// <returns></returns>
    public static decimal ComputeDefectProbability(decimal upper_specification_limit, decimal lower_specification_limit, decimal process_mean, decimal process_standard_deviation)
    {
        if (process_standard_deviation == 0) return decimal.MaxValue; // Avoid division by zero, implies infinite capability

        decimal probability_below_lower = CumulativeNormDist(lower_specification_limit, process_mean, process_standard_deviation);
        // 1 - CDF gives us the right tail probability, which is the probability of being above the upper specification limit
        decimal probability_above_upper = 1 - CumulativeNormDist(upper_specification_limit, process_mean, process_standard_deviation); 

        return (probability_above_upper + probability_below_lower);
    }

    /// <summary>
    /// Computes the target standard deviation for a process based on the specified upper and lower specification limits and the desired process capability index (Cp).
    /// </summary>
    /// <param name="upper_specification_limit">The upper bound of the specification range. Must be greater than <paramref name="lower_specification_limit"/>.</param>
    /// <param name="lower_specification_limit">The lower bound of the specification range. Must be less than <paramref name="upper_specification_limit"/>.</param>
    /// <param name="target_capability_index">The desired process capability index (Cp) for the process.</param>
    /// <returns>The calculated standard deviation for the specified specification limits and target capability index.</returns>
    public static decimal ComputeTargetStandardDeviation(decimal upper_specification_limit, decimal lower_specification_limit, decimal target_capability_index)
    {
        decimal specification_width = upper_specification_limit - lower_specification_limit;
        return specification_width / (6 * target_capability_index);
        // Note: The 6 in the denominator comes from the idea that 99.6% of values should be within 3 std of the mean.
        // Therefore, if the difference in the upper and lower specification limit is the same as the spread of 6 std (3 std x 2 tails of the distribution),
        // then we get a value of 1 for the Capability Index.
        // This is a mathematical trick to standardize the index so that a value of 1 corresponds to a process that is just capable of meeting specifications.
        // Other the other hand, values greater than 1 indicate a more capable process (specification range is greater than the variance) and values less than 1 indicate an incapable process (specification range is less than the variance).
    }

    /// <summary>
    /// CumulativeNormDist calculates the cumulative distribution function (CDF) for a normal distribution with a given mean and standard deviation at a specific observation point.
    /// </summary>
    /// <param name="observation"></param>
    /// <param name="mean"></param>
    /// <param name="std"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private static decimal CumulativeNormDist(decimal observation, decimal mean, decimal std)
    {
        throw new NotImplementedException();
        // Implementation of the standard normal distribution function (CDF)
    }


}
