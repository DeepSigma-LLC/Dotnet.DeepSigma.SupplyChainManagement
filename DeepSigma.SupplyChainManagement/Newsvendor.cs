
namespace DeepSigma.SupplyChainManagement;

internal class Newsvendor
{
    public decimal ActualDemand { get; set; }
    public decimal ExpectedProfitMaximizingOrderQuantity { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }
    public decimal MaxProfit => (Price - Cost) * ActualDemand;
    public decimal ExpectedProfit => (Price - Cost) * ExpectedProfitMaximizingOrderQuantity;
    public decimal ExpectedSupplyDemandMismatchCost => MaxProfit - ExpectedProfit;

    public required decimal OverageCost {  get; set; }
    public required decimal UnderageCost { get; set; }
    public decimal CriticalRatio => UnderageCost / (OverageCost + UnderageCost);
}
