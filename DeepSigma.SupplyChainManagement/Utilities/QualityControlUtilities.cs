
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

        decimal probability_below_lower = StatisticalUtilities.CumulativeNormDist(lower_specification_limit, process_mean, process_standard_deviation);
        // 1 - CDF gives us the right tail probability, which is the probability of being above the upper specification limit
        decimal probability_above_upper = 1 - StatisticalUtilities.CumulativeNormDist(upper_specification_limit, process_mean, process_standard_deviation); 

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
    /// Calculates the upper control limit for a process based on the specified mean, standard deviation, and control
    /// limit multiplier.
    /// </summary>
    /// <remarks>This method is commonly used in statistical process control to establish a threshold for
    /// detecting significant deviations in process behavior.</remarks>
    /// <param name="process_mean">The mean value of the process, representing the central tendency of the process data.</param>
    /// <param name="process_standard_deviation">The standard deviation of the process, indicating the amount of variation or dispersion in the process data.</param>
    /// <param name="control_limit_multiplier">The number of standard deviations to add to the mean to determine the upper control limit. Defaults to 3.</param>
    /// <returns>The upper control limit as a decimal value, calculated by adding the product of the control limit multiplier and
    /// the standard deviation to the process mean.</returns>
    public static decimal UpperControlLimit(decimal process_mean, decimal process_standard_deviation, decimal control_limit_multiplier = 3) => process_mean + control_limit_multiplier * process_standard_deviation;
    
    /// <summary>
    /// Calculates the lower control limit for a process based on the specified mean, standard deviation, and control
    /// limit multiplier.
    /// </summary>
    /// <remarks>This method is commonly used in statistical process control to establish the threshold below
    /// which process values are considered unusually low. The default multiplier of 3 corresponds to the typical
    /// three-sigma control limit.</remarks>
    /// <param name="process_mean">The mean value of the process, representing the central tendency of the process data.</param>
    /// <param name="process_standard_deviation">The standard deviation of the process, indicating the amount of variation or dispersion in the process data.</param>
    /// <param name="control_limit_multiplier">The number of standard deviations to subtract from the mean to determine the lower control limit. Defaults to 3.</param>
    /// <returns>The calculated lower control limit as a decimal value.</returns>
    public static decimal LowerControlLimit(decimal process_mean, decimal process_standard_deviation, decimal control_limit_multiplier = 3) => process_mean - control_limit_multiplier * process_standard_deviation;

    /// <summary>
    /// Calculates the probability that an event with a specified probability occurs independently a given number of
    /// times.
    /// For example, if you have a random process the probability of ending up on one side of the mean should be 0.5, and the probability of ending up on the other side of the mean should also be 0.5. 
    /// If you want to know the probability of ending up on the same side of the mean 3 times in a row, you would calculate 0.5^3 = 0.125, which means there is a 12.5% chance of that happening.
    /// </summary>
    /// <remarks>This method assumes that each occurrence of the event is independent and that the probability
    /// remains constant across all occurrences.</remarks>
    /// <param name="probability_event">The probability of a single occurrence of the event, expressed as a decimal value between 0 and 1.</param>
    /// <param name="number_of_occurance">The number of independent occurrences to consider. Must be non-negative.</param>
    /// <returns>The probability that the event occurs in all specified independent occurrences, as a decimal value between 0 and
    /// 1.</returns>
    public static decimal ProbabilityOfMultipleIndependentOccurance(decimal probability_event, double number_of_occurance) => (decimal)Math.Pow((double)probability_event,number_of_occurance);

    /// <summary>
    /// Calculates the yield of non-defective resources as a decimal ratio of total resources produced.
    /// </summary>
    /// <param name="total_resources_produced">The total number of resources produced. Must be greater than zero to avoid division by zero.</param>
    /// <param name="defective_resources_produced">The number of resources classified as defective. Cannot be negative and should not exceed the total resources
    /// produced.</param>
    /// <returns>A decimal value representing the proportion of non-defective resources to total resources produced. Returns 0 if
    /// all resources are defective, and 1 if there are no defective resources.</returns>
    public static decimal ResourceYield(decimal total_resources_produced, decimal defective_resources_produced) => (total_resources_produced - defective_resources_produced) / total_resources_produced;

    /// <summary>
    /// Calculates the number of flow units required to achieve a specified target yield, based on the process yield.
    /// </summary>
    /// <remarks>If <paramref name="process_yield"/> is zero, the method will throw a division by zero
    /// exception. Ensure that <paramref name="process_yield"/> is greater than zero before calling this
    /// method.</remarks>
    /// <param name="target_flow_units">The total number of flow units that must meet the target criteria.</param>
    /// <param name="process_yield">The yield of the process, expressed as a decimal value between 0 and 1, representing the proportion of flow
    /// units that successfully meet the target criteria. Must not be zero.</param>
    /// <returns>A decimal value representing the number of flow units that need to be processed to achieve the specified target
    /// yield.</returns>
    public static decimal ComputeNeededFlowUnitsToAchieveTargetYield(decimal target_flow_units, decimal process_yield) => target_flow_units / process_yield;
}
