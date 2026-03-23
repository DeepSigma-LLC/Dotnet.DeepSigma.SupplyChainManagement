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
            ActualDemand = 4000
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


    }
}
