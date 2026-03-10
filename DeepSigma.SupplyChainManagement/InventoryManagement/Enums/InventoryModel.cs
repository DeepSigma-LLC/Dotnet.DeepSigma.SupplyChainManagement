
namespace DeepSigma.SupplyChainManagement.InventoryManagement.Enums;

/// <summary>
/// Inventory models are mathematical frameworks used to analyze and optimize inventory management decisions.
/// </summary>
public enum InventoryModel
{
    /// <summary>
    /// Economic order quantity (EOQ) model is a fundamental inventory management model that helps determine the optimal order quantity for a product.
    /// The EOQ model aims to minimize the total cost of inventory, which includes ordering costs (the cost of placing an order) and holding costs (the cost of storing inventory).
    /// The EOQ model assumes a constant demand rate (demand is not stochastic), fixed ordering costs, and constant holding costs.
    /// However, the EOQ model does result in robust order quantity decisions even when demand is not constant, as it provides a baseline for understanding the trade-offs between ordering and holding costs.
    /// </summary>
    EconomicOrderQuantityModel,
    /// <summary>
    /// Newsvendor model is a single-period inventory model that helps determine the optimal order quantity for products with uncertain demand and a limited selling season. 
    /// It balances the cost of ordering too much (which can lead to excess inventory and waste) against the cost of ordering too little (which can lead to lost sales and customer dissatisfaction). 
    /// The model takes into account factors such as demand distribution, unit cost, selling price, and salvage value to calculate the optimal order quantity that maximizes expected profit or minimizes expected costs.
    /// The newsvendor model is a push-based inventory management approach, as it relies on forecasts of demand to determine the order quantity before the selling season begins.
    /// </summary>
    NewsvendorModel,
    /// <summary>
    /// Order up to model, also known as the "base stock model" or "order point model", is a continuous review inventory model that helps determine the optimal order quantity and reorder point for products with uncertain demand.
    /// In this model, the inventory level is continuously monitored, and an order is placed when the inventory level falls to a predetermined reorder point. 
    /// The order quantity is typically set to bring the inventory level back up to a specified "order up to" level, which is calculated based on factors such as demand distribution, lead time, and service level requirements. 
    /// The goal of the order up to model is to minimize total inventory costs while ensuring that customer demand is met with a high level of service.
    /// This model is a pull-based inventory management approach, as it relies on actual demand to trigger replenishment orders.
    /// </summary>
    OrderUpToModel,
}
