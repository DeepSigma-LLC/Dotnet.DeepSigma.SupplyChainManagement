using DeepSigma.SupplyChainManagement.InventoryManagement;
using Xunit;

namespace DeepSigma.SupplyChainManagement.Test;

public class OrderQuantityService_Test
{
    [Fact]
    public void ComputeRecommendedBatchSize_ValidResult()
    {
        decimal flow_rate = 0.333m; // 1 flow unit per minutes
        decimal setup_time = 120; // minutes
        decimal processing_time = 2; //minutes

        decimal result = OrderQuantityService.RecommendedBatchSize(flow_rate,setup_time, processing_time);
        decimal expected = 120;
        Assert.Equal(expected, result,0);
    }

    [Fact]
    public void ComputeEconomicOrderQuantity_ValidResult()
    {
        decimal flow_rate = 700; // units per week
        decimal inventory_cost = 0.006538m; // dollars per unit per week
        decimal fixed_order_cost = 300; // dollars per order

        decimal result = OrderQuantityService.EconomicOrderQuantity(fixed_order_cost, flow_rate, inventory_cost);
        decimal expected = 8014.97m;
        Assert.Equal(expected, result,1);
    }

    [Fact]
    public void ComputeEconomicOrderQuantityCost_ValidResult()
    {
        decimal flow_rate = 800; // units per week
        decimal inventory_cost = 0.006538m; // dollars per unit per week
        decimal fixed_order_cost = 300; // dollars per order

        decimal result = OrderQuantityService.EconomicOrderQuantityCost(fixed_order_cost, flow_rate, inventory_cost);
        decimal expected = 56m;
        Assert.Equal(expected, result,0);
    }

    [Fact]
    public void ComputeEconomicOrderQuantityCostPerUnit_ValidResult()
    {
        decimal flow_rate = 800; // units per week
        decimal inventory_cost = 0.006538m; // dollars per unit per week
        decimal fixed_order_cost = 300; // dollars per order

        decimal result = OrderQuantityService.EconomicOrderQuantityCostPerUnit(fixed_order_cost, flow_rate, inventory_cost);
        decimal expected = 0.07m;
        Assert.Equal(expected, result,2);
    }

    [Fact]
    public void ComputeInventoryCost_ValidResult()
    {
        decimal batch_size = 1000; // units
        decimal inventory_cost = 0.1m; // dollars per unit per week

        decimal result = OrderQuantityService.InventoryCostsPerUnitOfTime(batch_size, inventory_cost);
        decimal expected = 50m;
        Assert.Equal(expected, result, 2);
    }

    [Fact]
    public void ComputeSetupCostPerUnitOfTime_ValidResult()
    {
        decimal setup_cost = 300; // dollars per order
        decimal flow_rate = 800; // units per week
        decimal batch_size = 1000; // units 

        decimal result = OrderQuantityService.SetupCostsPerUnitOfTime(setup_cost, flow_rate, batch_size);
        decimal expected = setup_cost * flow_rate / batch_size;
        Assert.Equal(expected, result, 2);
    }
}