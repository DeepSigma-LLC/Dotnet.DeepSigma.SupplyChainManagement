
namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;


/// <summary>
/// Outlines the two primary tradeoffs between make-to-stock and make-to-order production strategies: Idle Capacity and Lost Sales.
/// </summary>
public enum MakeToStockVerseOrderTradeoff
{
    /// <summary>
    /// Make to order requires idle capacity, as production is only initiated after receiving a customer order. This can lead to underutilization of resources and increased costs, as the company may need to maintain excess capacity to meet potential demand fluctuations.
    /// </summary>
    IdleCapacity,
    /// <summary>
    /// Lost sales can occur in a make-to-order system if the company is unable to fulfill customer orders in a timely manner due to capacity constraints or production delays. 
    /// This can lead to customer dissatisfaction and lost revenue, as customers may choose to take their business elsewhere if they experience long wait times or unfulfilled orders. 
    /// In contrast, a make-to-stock system can help to mitigate this risk by maintaining inventory levels that can meet customer demand, reducing the likelihood of lost sales and improving customer satisfaction.
    /// To avoid 
    /// </summary>
    LostSales,
}
