using Xunit;
using DeepSigma.SupplyChainManagement;

namespace DeepSigma.SupplyChainManagement.Test;


public class Newsvendor_Test
{
    [Fact]
    public void Test_Newsvendor()
    {
        Newsvendor newsvendor = new()
        {
            Mean = 3192,
            StandardDeviation = 1181,
            OverageCost = 20,
            UnderageCost = 80,
            SelectedValue = 3500,
            Price = 120,
            Cost = 40,
            SalvageValue = 20,
            ActualDemand = 4195.85m * 0.9m // 10% less than mean
        };
        Assert.Equal(0.8m, newsvendor.CriticalRatio);
        Assert.Equal(0.84m, newsvendor.CriticalRatio_ZScore, 2);
        Assert.Equal(0.85m, newsvendor.CriticalRatio_ZScore_Rounded, 2);
        Assert.Equal(4195.85m, newsvendor.OptimalQuantity, 2);
        Assert.Equal(0.282m, newsvendor.Loss, 3);
        Assert.Equal(333, newsvendor.ExpectedLossSales, 0);
        Assert.Equal(2858.9m, newsvendor.ExpectedSales, 1);
        Assert.Equal(newsvendor.Mean, newsvendor.ExpectedDemand);
        Assert.Equal(641m, newsvendor.ExpectedLeftoverInventory, 0);

        Assert.Equal(343070.02m, newsvendor.ExpectedRevenue, 2);
        Assert.Equal(114356.67m, newsvendor.ExpectedCostOfGoodsSold, 2);
        Assert.Equal(12821.66m, newsvendor.ExpectedLossOnSalvage, 2);
        Assert.Equal(127178.34m, newsvendor.TotalExpectedCost, 2);
        Assert.Equal(215891.68m, newsvendor.ExpectedProfit, 2);
        Assert.Equal(0.6029m, newsvendor.GetInstockProbability(3500), 4);
        Assert.Equal(0.3971m, newsvendor.GetStockoutProbability(3500), 4);

        decimal target_quantity = newsvendor.ComputeQuantityToTargetServiceLevel(0.99m);
        Assert.Equal(5939.4m, target_quantity, 1);

        Assert.Equal(newsvendor.Margin * newsvendor.ActualDemand, newsvendor.MaxProfit, 2);
        Assert.Equal(39468.32m, newsvendor.MismatchCost, 2);

        Assert.Equal(0.9m ,newsvendor.AFRatio, 2);
        decimal calibrated_forecast = newsvendor.CalculateCalibratedForecast(3500);
        Assert.Equal(3500m * 0.9m, calibrated_forecast, 1);
    }
}
