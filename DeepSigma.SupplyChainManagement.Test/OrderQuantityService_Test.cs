using DeepSigma.SupplyChainManagement.InventoryManagement;
using Xunit;

namespace DeepSigma.SupplyChainManagement.Test;

public class OrderQuantityService_Test
{
    [Fact]
    public void ComputeRecommendedBatchSize_ValidResult()
    {
        decimal result = OrderQuantityService.RecommendedBatchSize(10, 5, 2);
        decimal expected = 10 * 5 / 2;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ComputeEconomicOrderQuantity_ValidResult()
    {
        decimal result = OrderQuantityService.EconomicOrderQuantity(10, 5, 2);
        decimal expected = Math.Sqrt(2 * 10 * 5 / 2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ComputeEconomicOrderQuantityCost_ValidResult()
    {
        decimal result = OrderQuantityService.EconomicOrderQuantityCost(10, 5, 2);
        decimal expected = Math.Sqrt(2 * 10 * 5 * 2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ComputeEconomicOrderQuantityCostPerUnit_ValidResult()
    {
        decimal result = OrderQuantityService.EconomicOrderQuantityCostPerUnit(10, 5, 2);
        decimal expected = Math.Sqrt(2 * 10 * 5 * 2) / Math.Sqrt(2 * 10 * 5 / 2);
        Assert.Equal(expected, result);
    }
}