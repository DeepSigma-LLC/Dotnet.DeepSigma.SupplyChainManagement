

namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Production Mode of Operation specifies the two primary production strategies used in manufacturing and supply chain management: Make to Stock and Make to Order.
/// </summary>
public enum ProductionModeOfOperation
{
    /// <summary>
    /// Make to stock refers to a production strategy where products are manufactured in anticipation of customer demand and are kept in inventory until they are sold. T
    /// his approach allows for faster order fulfillment and can be more efficient for products with stable demand patterns, but it also carries the risk of overproduction and excess inventory if demand is overestimated.
    /// </summary>
    MakeToStock,
    /// <summary>
    /// Make to order refers to a production strategy where products are manufactured only after a customer order is received. This approach minimizes inventory levels and reduces the risk of overproduction, but it may result in longer lead times for customers.
    /// For example, in a make-to-order system, a customer might place an order for a custom-built computer, and the manufacturer would only begin production after receiving the order. 
    /// This allows for greater customization and can help to reduce waste, but it may also require more flexible manufacturing processes and supply chain management to ensure timely delivery of products to customers.
    /// Also known as build-to-order or assemble-to-order, this approach is often used for products with highly variable demand or for products that require a high degree of customization, as it allows manufacturers to respond more quickly to changes in customer preferences and market conditions while minimizing the risk of excess inventory and waste.
    /// </summary>
    MakeToOrder,
}
