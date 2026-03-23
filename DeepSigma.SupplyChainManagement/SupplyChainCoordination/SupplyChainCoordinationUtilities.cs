
namespace DeepSigma.SupplyChainManagement.SupplyChainCoordination;

/// <summary>
/// Provides utility methods for coordinating supply chain decisions between manufacturers and retailers, with a focus
/// on optimizing total profit through incentive alignment mechanisms such as buy-back pricing.
/// </summary>
/// <remarks>This class contains static methods that implement supply chain coordination strategies based on
/// established models, such as the newsvendor model. These methods are intended to help users design and analyze supply
/// chain contracts that balance inventory risks and rewards, improve efficiency, and maximize overall profitability.
/// All members are thread-safe due to their stateless nature.</remarks>
public static class SupplyChainCoordinationUtilities
{
    /// <summary>
    /// Calculate the buy-back price that maximizes the total profit of the supply chain.
    /// This formula is derived from the newsvendor model, which considers the trade-off between ordering too much (leading to excess inventory) and ordering too little (leading to lost sales). The buy-back price is set to balance these costs and maximize the overall profit of the supply chain.
    /// The resulting buy-back price ensures that the retailer is incentivized to order the optimal quantity of products, while the manufacturer can recover some of the costs associated with unsold inventory. This coordination mechanism helps align the incentives of both parties and improves the efficiency of the supply chain.
    /// The price is said to "coordinate" the supply chain because it helps to align the incentives of the retailer and the manufacturer, leading to a more efficient outcome for both parties.  
    /// This coordination mechanism helps to improve the overall performance of the supply chain and maximize total profit.
    /// </summary>
    /// <param name="price"></param>
    /// <param name="cost"></param>
    /// <param name="salvage_value"></param>
    /// <param name="whole_sale_price"></param>
    /// <param name="shipping_cost"></param>
    /// <returns></returns>
    public static decimal BuyBackPriceToMaximizeSupplyChainTotalProfit(decimal price, decimal cost, decimal salvage_value,  decimal whole_sale_price, decimal shipping_cost)
    {
        return shipping_cost + price + (price - whole_sale_price) * (price - salvage_value) / (price - cost);
    }
}
