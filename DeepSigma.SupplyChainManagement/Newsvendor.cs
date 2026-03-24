using DeepSigma.General.Extensions;
using DeepSigma.Mathematics.Statistics;

namespace DeepSigma.SupplyChainManagement;

/// <summary>
/// Newsvendor is a class that represents the newsvendor model, which is a mathematical model used in inventory management to determine the optimal order quantity for a product with uncertain demand. The model takes into account factors such as actual demand, price, cost, salvage value, and the distribution of demand to calculate key metrics such as margin, maximum profit, critical ratio, optimal quantity, expected loss, expected sales, expected revenue, and expected profit. The newsvendor model helps businesses make informed decisions about inventory management and pricing strategies to maximize profitability while minimizing costs associated with overstocking and understocking.
/// </summary>
public class Newsvendor
{
    /// <summary>
    /// Actual demand represents the real quantity of a product that customers will purchase during a specific period. 
    /// It is a critical factor in the newsvendor model, as it directly influences inventory decisions and profitability. 
    /// Accurate estimation of actual demand is essential for determining the optimal order quantity, as it helps balance the costs of overstocking (ordering too much) and understocking (ordering too little).
    /// In the newsvendor model, actual demand is often treated as a random variable with a known probability distribution, allowing businesses to make informed decisions based on expected demand and its variability.
    /// </summary>
    public decimal ActualDemand { get; set; }

    /// <summary>
    /// Price represents the selling price of a product, which is a critical factor in the newsvendor model as it directly impacts revenue and profitability.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Cost represents the unit cost of a product, which is a critical factor in the newsvendor model as it directly impacts the cost of goods sold and profitability.
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// Salvage value represents the residual value of a product that cannot be sold at the full price, which is a critical factor in the newsvendor model as it directly impacts the cost of overstocking and profitability.
    /// </summary>
    public decimal SalvageValue { get; set; } = 0;

    /// <summary>
    /// Loss on salvage is the financial loss incurred when a product is sold at a salvage value that is lower than its original cost.
    /// It is calculated as the difference between the cost of the product and its salvage value. This metric is important for understanding the potential financial impact of unsold inventory or products that need to be disposed of, and it can help businesses make informed decisions about inventory management and pricing strategies to minimize losses associated with salvage.
    /// </summary>
    public decimal LossOnSavage => Cost - SalvageValue;

    /// <summary>
    /// Margin is the difference between the selling price of a product and its cost, representing the profit made on each unit sold.
    /// </summary>
    public decimal Margin => Price - Cost;

    /// <summary>
    /// Max profit is the maximum potential profit that can be achieved in a newsvendor model, calculated as the product of the margin (the difference between the selling price and the cost) and the actual demand.
    /// </summary>
    public decimal MaxProfit => Margin * ActualDemand;

    /// <summary>
    /// Selected value represents the order quantity chosen by users.
    /// </summary>
    public required decimal SelectedValue {  get; set; }

    /// <summary>
    /// Mean represents the average demand for a product over a specific period, calculated as the sum of all demand values divided by the number of observations.
    /// </summary>
    public required decimal Mean { get; set; }

    /// <summary>
    /// Standard deviation is a measure of the variability or dispersion of demand around the mean in the newsvendor model.
    /// It quantifies the extent to which demand values deviate from the average demand, providing insight into the level of uncertainty associated with demand forecasts.
    /// A higher standard deviation indicates greater variability in demand, which can increase the risk of overstocking or understocking inventory.
    /// Understanding the standard deviation of demand is crucial for making informed inventory decisions and optimizing order quantities to balance costs and service levels effectively.
    /// </summary>
    public required decimal StandardDeviation { get; set; }

    /// <summary>
    /// Coeffiecient of variation (CV) is a standardized measure of the relative variability of demand in the newsvendor model, calculated as the ratio of the standard deviation to the mean.
    /// </summary>
    public decimal CoefficientOfVariation => StandardDeviation / Mean;

    /// <summary>
    /// Gets the Z-score of the selected value, calculated based on the mean and standard deviation.
    /// </summary>
    /// <remarks>The Z-score represents the number of standard deviations a data point is from the mean. It is
    /// useful for understanding the relative position of the selected value within a statistical
    /// distribution.</remarks>
    public decimal SelectedValue_ZScore => StatisticsUtilities.CalculateZScore(SelectedValue, Mean, StandardDeviation);

    /// <summary>
    /// Probability less than or equal to the selected value is calculated using the cumulative distribution function (CDF) of the normal distribution, which provides the probability that a random variable will take a value less than or equal to the selected value based on its Z-score.
    /// </summary>
    public decimal ProbabilityLessThanOrEqualTo => StatisticsUtilities.CalculateCDF(0, 1, SelectedValue_ZScore);

    /// <summary>
    /// Probability greater than the selected value is calculated as the complement of the probability less than or equal to the selected value, representing the probability that a random variable will take a value greater than the selected value based on its Z-score.
    /// </summary>
    public decimal ProbabilityGreaterThan => 1 - ProbabilityLessThanOrEqualTo;

    /// <summary>
    /// Overage cost is the cost incurred when ordering more inventory than the actual demand, which can lead to excess inventory and associated holding costs.
    /// </summary>
    public required decimal OverageCost { get; set; }

    /// <summary>
    /// Underage cost is the cost incurred when ordering less inventory than the actual demand, which can lead to lost sales and customer dissatisfaction.
    /// </summary>
    public required decimal UnderageCost { get; set; }

    /// <summary>
    /// Critical Ratio is a key concept in the newsvendor model that represents the trade-off between the costs of overstocking and understocking inventory. 
    /// It is calculated as the ratio of the underage cost (the cost of not having enough inventory to meet demand) to the sum of the overage cost (the cost of having excess inventory) and the underage cost. 
    /// The critical ratio helps determine the optimal order quantity that maximizes expected profit by balancing the costs/risks associated with both overstocking and understocking. 
    /// A higher critical ratio indicates a greater emphasis on avoiding stockouts, while a lower critical ratio suggests a focus on minimizing excess inventory costs.
    /// </summary>
    public decimal CriticalRatio => UnderageCost / (OverageCost + UnderageCost);

    /// <summary>
    /// Critical Ratio Z-Score is the z-score corresponding to the critical ratio, calculated using the inverse cumulative distribution function (CDF) of the normal distribution.
    /// </summary>
    public decimal CriticalRatio_ZScore => StatisticsUtilities.CalculateNormInverse(CriticalRatio, 0, 1);

    /// <summary>
    /// Critical Ratio Z-Score Rounded is the z-score corresponding to the critical ratio, rounded up to 2 decimal places.
    /// This rounding follows the roundup rule which ensures that the rounded value is always greater than or equal to the original value, which can be important in inventory management decisions to avoid underestimating the optimal order quantity.
    /// </summary>
    public decimal CriticalRatio_ZScore_Rounded => RoundUp(CriticalRatio_ZScore,2);

    /// <summary>
    /// Rounds up a decimal number to a specified number of decimal places.
    /// </summary>
    /// <param name="number">The decimal number to be rounded up.</param>
    /// <param name="places">The number of decimal places to round up to.</param>
    /// <returns>The rounded-up decimal number.</returns>
    private static decimal RoundUp(decimal number, int places)
    {
        decimal factor = Math.Pow(10, places).ToDecimal();
        decimal roundedNumber = Math.Ceiling(number * factor) / factor;
        return roundedNumber;
    }

    /// <summary>
    /// Optimal quantity is the order quantity that maximizes expected profit in the newsvendor model, calculated as the mean demand plus the product of the critical ratio z-score and the standard deviation of demand.
    /// </summary>
    public decimal OptimalQuantity => Mean + CriticalRatio_ZScore_Rounded * StandardDeviation;

    /// <summary>
    /// Loss represents the expected loss incurred when the selected order quantity is less than the actual demand, calculated as the difference between the expected demand and the selected order quantity, weighted by the probability of demand exceeding the selected order quantity.
    /// </summary>
    public decimal Loss => StatisticsUtilities.CalculatePDF(mean:0, 1, SelectedValue_ZScore) - SelectedValue_ZScore * ProbabilityGreaterThan;

    /// <summary>
    /// Expected loss on sales is the expected financial loss incurred when the selected order quantity is less than the actual demand, calculated as the product of the standard deviation of demand and the expected loss.
    /// </summary>
    public decimal ExpectedLossSales => StandardDeviation * Loss;

    /// <summary>
    /// Expected sales is the expected quantity of products sold based on the selected order quantity, calculated as the mean demand minus the expected loss on sales.
    /// This metric provides insight into the expected performance of the inventory decision based on the selected order quantity and the variability of demand.
    /// </summary>
    public decimal ExpectedSales => Mean - ExpectedLossSales;

    /// <summary>
    /// Expected demand is the total expected quantity of products demanded, calculated as the sum of expected sales and expected loss on sales.
    /// This metric represents the overall demand for the product, taking into account both the expected sales and the potential losses due to understocking.
    /// It provides a comprehensive view of the demand landscape, helping businesses make informed inventory decisions to balance costs and service levels effectively.
    /// </summary>
    public decimal ExpectedDemand => ExpectedSales + ExpectedLossSales; // also mean

    /// <summary>
    /// Exected leftover inventory is the expected quantity of products that will remain unsold based on the selected order quantity, calculated as the difference between the selected order quantity and the expected sales.
    /// </summary>
    public decimal ExpectedLeftoverInventory => SelectedValue - ExpectedSales;

    /// <summary>
    /// Expected revenue is the total expected revenue generated from sales based on the selected order quantity, calculated as the product of the selling price and the expected sales.
    /// </summary>
    public decimal ExpectedRevenue => Price * ExpectedSales;

    /// <summary>
    /// Expected cost of goods sold is the total expected cost incurred from selling products based on the selected order quantity, calculated as the product of the unit cost and the expected sales.
    /// </summary>
    public decimal ExpectedCostOfGoodsSold => Cost * ExpectedSales;

    /// <summary>
    /// Expected loss on salvage is the total expected loss incurred from unsold products based on the selected order quantity, calculated as the product of the loss on salvage and the expected leftover inventory.
    /// </summary>
    public decimal ExpectedLossOnSalvage => LossOnSavage * ExpectedLeftoverInventory;

    /// <summary>
    /// Total expected cost is the sum of the expected cost of goods sold and the expected loss on salvage, representing the total expected costs associated with the inventory decision based on the selected order quantity and the variability of demand.
    /// </summary>
    public decimal TotalExpectedCost => ExpectedCostOfGoodsSold + ExpectedLossOnSalvage;

    /// <summary>
    /// Expected profit is the difference between the expected revenue and the total expected cost, representing the overall profitability of the inventory decision based on the selected order quantity and the variability of demand.
    /// </summary>
    public decimal ExpectedProfit => ExpectedRevenue - TotalExpectedCost;

    /// <summary>
    /// Get instock probability is a method that calculates the probability of having enough inventory to meet demand based on the order quantity, mean demand, and standard deviation of demand.
    /// It uses the cumulative distribution function (CDF) of the normal distribution to determine the probability that demand will be less than or equal to the order quantity, which is equivalent to the probability of being in stock.
    /// The method takes the order quantity as input and calculates the z-score for that order quantity using the mean and standard deviation of demand.
    /// </summary>
    /// <param name="order_quantity">The order quantity for which to calculate the in-stock probability. Must be a non-negative decimal.</param>
    /// <returns>The probability of having enough inventory to meet demand, represented as a decimal value between 0 and 1.</returns>
    public decimal GetInstockProbability(decimal order_quantity)
    {
        decimal z_score = StatisticsUtilities.CalculateZScore(order_quantity, Mean, StandardDeviation);
        return StatisticsUtilities.CalculateCDF(0, 1, z_score);
    }

    /// <summary>
    /// Get stockout probability is a method that calculates the probability of a stockout occurring based on the order quantity, mean demand, and standard deviation of demand.
    /// It uses the cumulative distribution function (CDF) of the normal distribution to determine the probability that demand will exceed the order quantity, which is equivalent to the probability of a stockout.
    /// </summary>
    /// <param name="order_quantity">The order quantity for which to calculate the stockout probability. Must be a non-negative decimal.</param>
    /// <returns>The probability of a stockout occurring, represented as a decimal value between 0 and 1.</returns>
    public decimal GetStockoutProbability(decimal order_quantity) => 1 - GetInstockProbability(order_quantity);
    

    /// <summary>
    /// Calculates the required quantity to achieve a specified target service level based on the mean and standard
    /// deviation of the demand distribution.
    /// </summary>
    /// <remarks>The method uses the inverse cumulative distribution function (z-score) for the normal
    /// distribution to determine the appropriate quantity. Ensure that the service level is within the valid range
    /// (greater than 0 and less than 1) to avoid invalid results.</remarks>
    /// <param name="service_level">The target service level as a decimal value between 0 and 1, representing the desired probability of meeting
    /// demand.</param>
    /// <returns>The quantity needed to meet the specified service level, calculated using the normal distribution.</returns>
    public decimal ComputeQuantityToTargetServiceLevel(decimal service_level)
    {
        decimal z_score = StatisticsUtilities.CalculateNormInverse(service_level, 0, 1);
        return Mean + z_score * StandardDeviation;
    }

    /// <summary>
    /// Mismatch cost is the expected cost associated with the difference between the actual demand and the order quantity.
    /// It is calculated as the sum of the expected cost of overstocking (the cost of having excess inventory) and the expected cost of understocking (the cost of not having enough inventory to meet demand).
    /// Processes with a higher coefficient of variation (CV) in demand will generally have a higher mismatch cost, as the variability in demand increases the likelihood of both overstocking and understocking, leading to higher expected costs associated with inventory mismatches.
    /// </summary>
    public decimal MismatchCost => OverageCost * ExpectedLeftoverInventory + UnderageCost * ExpectedLossSales;

    /// <summary>
    /// Actual to Forecast Ratio (AFRatio) is a metric that compares the actual demand to the optimal quantity determined by the newsvendor model.
    /// It provides insight into how well the forecasted demand aligns with the actual demand, helping to assess the accuracy of demand predictions and adjust inventory decisions accordingly.
    /// </summary>
    public decimal AFRatio => ActualDemand / OptimalQuantity;

    /// <summary>
    /// Calculates the calibrated forecast by applying the adjustment factor ratio to the specified forecasted demand.
    /// </summary>
    /// <remarks>The adjustment factor ratio (AFRatio) is applied to the input value to produce the calibrated
    /// forecast. Ensure that the forecasted demand is non-negative to avoid invalid results.</remarks>
    /// <param name="forecasted_demand">The forecasted demand value to be adjusted. Must be a non-negative decimal.</param>
    /// <returns>The calibrated forecast as a decimal value, representing the forecasted demand after adjustment.</returns>
    public decimal CalculateCalibratedForecast(decimal forecasted_demand) => forecasted_demand * AFRatio;
}
