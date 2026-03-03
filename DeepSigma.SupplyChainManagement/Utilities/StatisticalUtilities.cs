

namespace DeepSigma.SupplyChainManagement.Utilities;

/// <summary>
/// Statistical utilities for calculating various statistical measures such as coefficient of variation, cumulative normal distribution, standard error, and estimating standard deviation from a range. These utilities can be used in various applications such as quality control, process analysis, and data analysis to help understand variability, make predictions, and make informed decisions based on statistical data.
/// </summary>
public static class StatisticalUtilities
{

    /// <summary>
    /// The coefficient of variation is a measure of relative variability that is calculated as the ratio of the standard deviation to the mean.
    /// </summary>
    /// <param name="standard_deviation">The standard deviation of the data set.</param>
    /// <param name="mean">The mean of the data set.</param>
    /// <returns>The coefficient of variation.</returns>
    public static decimal ComputeCoefficientOfVariation(decimal standard_deviation, decimal mean) => mean == 0 ? decimal.MaxValue : standard_deviation / mean; // Avoid division by zero, implies infinite coefficient of variation

    /// <summary>
    /// CumulativeNormDist calculates the cumulative distribution function (CDF) for a normal distribution with a given mean and standard deviation at a specific observation point.
    /// </summary>
    /// <param name="observation"></param>
    /// <param name="mean"></param>
    /// <param name="std"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static decimal CumulativeNormDist(decimal observation, decimal mean, decimal std)
    {
        throw new NotImplementedException();
        // Implementation of the standard normal distribution function (CDF)
    }

    /// <summary>
    /// Standard Error calculates the standard error of an estimate based on the estimate value and the sample size.
    /// </summary>
    /// <param name="estimate">The estimate value for which the standard error is being calculated.</param>
    /// <param name="sample_size">The size of the sample used to calculate the estimate.</param>
    /// <returns>The calculated standard error for the given estimate and sample size.</returns>
    public static decimal StandardError(decimal estimate, double sample_size) => estimate / (decimal)Math.Sqrt(sample_size);

    /// <summary>
    /// EstimateStandardDeviationFromRange provides an estimate of the standard deviation of a process based on the range defined by the upper and lower limits.
    /// This is not mathematically rigorous, but can be a useful heuristic when you have limited data and want to get a rough sense of the variability in the process.
    /// </summary>
    /// <param name="upper_limit">The upper limit of the range.</param>
    /// <param name="lower_limit">The lower limit of the range.</param>
    /// <returns>The estimated standard deviation based on the range.</returns>
    public static decimal EstimateStandardDeviationFromRange(decimal upper_limit, decimal lower_limit) => (upper_limit - lower_limit) / 4;
}
