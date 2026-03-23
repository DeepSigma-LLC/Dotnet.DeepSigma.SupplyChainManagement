using DeepSigma.General.Extensions;
using DeepSigma.Mathematics.Statistics;

namespace DeepSigma.SupplyChainManagement;

public class Newsvendor
{
    public decimal ActualDemand { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }
    public decimal SalvageValue { get; set; }
    public decimal LossOnSavage => Cost - SalvageValue;
    public decimal Margin => Price - Cost;

    public decimal MaxProfit => Margin * ActualDemand;
    public decimal ExpectedSupplyDemandMismatchCost => MaxProfit - ExpectedProfit;

  

    public required decimal SelectedValue {  get; set; }
    public required decimal Mean { get; set; }
    public required decimal StandardDeviation { get; set; }
    public decimal CoefficientOfVariation => StandardDeviation / Mean;
    public decimal SelectedValue_ZScore => StatisticsUtilities.CalculateZScore(SelectedValue, Mean, StandardDeviation);
    public decimal ProbabilityLessThanOrEqualTo => StatisticsUtilities.CalculateCDF(0, 1, SelectedValue_ZScore);
    public decimal ProbabilityGreaterThan => 1 - ProbabilityLessThanOrEqualTo;

    public required decimal OverageCost { get; set; }
    public required decimal UnderageCost { get; set; }

    /// <summary>
    /// Critical Ratio is a key concept in the newsvendor model that represents the trade-off between the costs of overstocking and understocking inventory. 
    /// It is calculated as the ratio of the underage cost (the cost of not having enough inventory to meet demand) to the sum of the overage cost (the cost of having excess inventory) and the underage cost. 
    /// The critical ratio helps determine the optimal order quantity that maximizes expected profit by balancing the costs/risks associated with both overstocking and understocking. 
    /// A higher critical ratio indicates a greater emphasis on avoiding stockouts, while a lower critical ratio suggests a focus on minimizing excess inventory costs.
    /// </summary>
    public decimal CriticalRatio => UnderageCost / (OverageCost + UnderageCost);

    public decimal CriticalRatio_ZScore => StatisticsUtilities.CalculateNormInverse(CriticalRatio, 0, 1);

    public decimal CriticalRatio_ZScore_Rounded => RoundUp(CriticalRatio_ZScore,2);

    private static decimal RoundUp(decimal number, int places)
    {
        decimal factor = Math.Pow(10, places).ToDecimal();
        decimal roundedNumber = Math.Ceiling(number * factor) / factor;
        return roundedNumber;
    }

    public decimal OptimalQuantity => Mean + CriticalRatio_ZScore_Rounded * StandardDeviation;

    public decimal Loss => StatisticsUtilities.CalculatePDF(mean:0, 1, SelectedValue_ZScore) - SelectedValue_ZScore * ProbabilityGreaterThan;

    public decimal ExpectedLossSales => StandardDeviation * Loss;

    public decimal ExpectedSales => Mean - ExpectedLossSales;

    public decimal ExpectedDemand => ExpectedSales + ExpectedLossSales; // also mean

    public decimal ExpectedLeftoverInventory => SelectedValue - ExpectedSales;

    public decimal ExpectedRevenue => Price * ExpectedSales;

    public decimal ExpectedCostOfGoodsSold => Cost * ExpectedSales;

    public decimal ExpectedLossOnSalvage => LossOnSavage * ExpectedLeftoverInventory;

    public decimal TotalExpectedCost => ExpectedCostOfGoodsSold + ExpectedLossOnSalvage;

    public decimal ExpectedProfit => ExpectedRevenue - TotalExpectedCost;

    public decimal GetInstockProbability(decimal order_quantity)
    {
        decimal z_score = StatisticsUtilities.CalculateZScore(order_quantity, Mean, StandardDeviation);
        return StatisticsUtilities.CalculateCDF(0, 1, z_score);
    }

    public decimal GetStockoutProbability(decimal order_quantity) => 1 - GetInstockProbability(order_quantity);
    

    public decimal ComputeQuantityToTargetServiceLevel(decimal service_level)
    {
        decimal z_score = StatisticsUtilities.CalculateNormInverse(service_level, Mean, StandardDeviation);
        return Mean + z_score * StandardDeviation;
    }

    /// <summary>
    /// Mismatch cost is the expected cost associated with the difference between the actual demand and the order quantity.
    /// It is calculated as the sum of the expected cost of overstocking (the cost of having excess inventory) and the expected cost of understocking (the cost of not having enough inventory to meet demand).
    /// Processes with a higher coefficient of variation (CV) in demand will generally have a higher mismatch cost, as the variability in demand increases the likelihood of both overstocking and understocking, leading to higher expected costs associated with inventory mismatches.
    /// </summary>
    public decimal MismatchCost => OverageCost * ExpectedLeftoverInventory + UnderageCost * ExpectedLossSales;

    public decimal AFRatio => ActualDemand / OptimalQuantity;

    public decimal CalculateCalibratedForecast(decimal forecasted_demand) => forecasted_demand * AFRatio;

}
