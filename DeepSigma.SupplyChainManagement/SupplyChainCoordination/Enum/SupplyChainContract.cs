
namespace DeepSigma.SupplyChainManagement.SupplyChainCoordination.Enum;


/// <summary>
/// Defines the types of supply chain contracts that facilitate collaboration between manufacturers and retailers to
/// optimize inventory management and sales performance.
/// </summary>
public enum SupplyChainContract
{
    /// <summary>
    /// Buy back contract is a type of supply chain contract where the manufacturer agrees to buy back unsold inventory from the retailer at a predetermined price. 
    /// This contract is designed to mitigate the risk of overstocking and encourages retailers to order more inventory, which can lead to increased sales and profits for both parties. 
    /// The buy-back price is typically set at a level that allows the retailer to recover a portion of their costs while still providing an incentive to order more products. 
    /// This contract decreases the overage cost for the retailer, which encourages them to order more inventory. 
    /// In the context of the newsvendor model, decreasing the overage cost increases the critical ratio for the retailer, which leads to a higher optimal order quantity. 
    /// </summary>
    BuyBackContract,
    /// <summary>
    /// Quantity discount contract is a type of supply chain contract where the manufacturer offers a discount on the unit price of products based on the quantity ordered by the retailer.
    /// This contract is designed to incentivize the retailer to order larger quantities of products, which can lead to economies of scale for the manufacturer and increased sales for both parties.
    /// However, the retailer must carefully consider the trade-off between the cost savings from the discount and the potential risks of overstocking, such as increased holding costs and the possibility of unsold inventory.
    /// In the context of the newsvendor model, a quantity discount increases the underage cost, thereby increasing the critical ratio.
    /// </summary>
    QuantityDiscountContract,
    /// <summary>
    /// Option contract is a type of supply chain contract that provides the retailer with the right, but not the obligation, to purchase a certain quantity of products from the manufacturer at a predetermined price (the exercise price) within a specified time frame. 
    /// The supplier earns at least something upfront (the option’s price) while the buyer doesn’t have to pay for all of the unused capacity. 
    /// The exercise price is paid only on capacity actually exercised.
    /// </summary>
    OptionContract,
    /// <summary>
    /// Revenue sharing contract is a type of supply chain contract where the manufacturer and retailer agree to share the revenue generated from the sales of products.
    /// In this contract, the manufacturer typically receives a percentage of the revenue from the sales of the products, while the retailer retains the remaining percentage.
    /// This contract aligns the incentives of both parties, encouraging them to work together to maximize sales and revenue.
    /// In the context of the newsvendor model, a revenue sharing contract can be designed to increase the critical ratio for the retailer, which can lead to a higher optimal order quantity.
    /// </summary>
    RevenueSharingContract,
    /// <summary>
    /// Quantity flexibility contract is a type of supply chain contract that allows the retailer to adjust the order quantity after the initial order has been placed, based on actual demand or other factors.
    /// This contract provides the retailer with greater flexibility in managing inventory and responding to changes in demand, while still providing the manufacturer with a level of certainty regarding production and supply.
    /// For example, a quantity flexibility contract may allow the retailer to increase or decrease the order quantity by a certain percentage or within a specified range, depending on the terms of the contract.
    /// This contract may have limits to the quantity adjustment or penalties for excessive adjustments, which can help to balance the interests of both parties and ensure that the contract remains beneficial for both the manufacturer and retailer.
    /// In the context of supply chain management, a quantity flexibility contract can help the retailer to better match supply with demand, which can lead to reduced costs and increased profits for both parties.
    /// </summary>
    QuantityFlexibilityContract,
    /// <summary>
    /// Price protection contract is a type of supply chain contract that provides the retailer with protection against price fluctuations in the market.
    /// In this contract, the manufacturer agrees to provide the retailer with a certain level of price protection, which can help to mitigate the risks associated with price volatility.
    /// For example, a price protection contract may specify that the manufacturer will reimburse the retailer for any losses incurred due to price drops in the market, or it may provide a guaranteed minimum price for the products sold by the retailer.
    /// This is helpful for retailers as it allows them to manage their inventory and pricing strategies with greater confidence, knowing that they have some level of protection against adverse market conditions.
    /// Avoids risk of inventory obsolescence for the retailer and encourages them to order more inventory, which can lead to increased sales and profits for both parties.
    /// Also, the tendency of suppliers to cut their wholesale prices frequently and without notice creates an incentive among distributors to be cautious in the purchase quantities. 
    /// If distributors then curtail their purchases below the supply chain optimal amount, it can be beneficial to provide them with an incentive to increase their order quantities by offering them a price protection contract.
    /// </summary>
    PriceProtectionContract
}
