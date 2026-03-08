

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
    /// <param name="divisor">The divisor used to estimate the standard deviation from the range. Default is 4 for small sample sizes such as less than 20.
    /// For larger sample sizes, a divisor of 6 is often used to provide a more accurate estimate of the standard deviation based on the range. 
    /// The choice of divisor can depend on the specific context and the desired level of precision in the estimate. The divisor comes from the fact that for a normal distribution, approximately 95% of the data falls within 2 standard deviations of the mean, which corresponds to a range of 4 standard deviations (2 on each side of the mean). 
    /// For larger sample sizes, using a divisor of 6 can provide a more accurate estimate of the standard deviation based on the range, as it accounts for the increased variability that can occur with larger samples.
    /// </param>
    /// <returns>The estimated standard deviation based on the range.</returns>
    public static decimal EstimateStandardDeviationFromRange(decimal upper_limit, decimal lower_limit, decimal divisor = 4) => (upper_limit - lower_limit) / divisor;
}
