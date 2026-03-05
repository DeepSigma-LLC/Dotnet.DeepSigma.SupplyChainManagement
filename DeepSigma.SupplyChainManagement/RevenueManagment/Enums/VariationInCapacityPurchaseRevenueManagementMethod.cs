namespace DeepSigma.SupplyChainManagement.RevenueManagment.Enums;

/// <summary>
/// Variation in Capacity Purchase Revenue Management Method refers to the different approaches and strategies that businesses can use to manage and optimize their revenue from capacity purchases.
/// </summary>
public enum VariationInCapacityPurchaseRevenueManagementMethod
{
    /// <summary>
    /// Single segment control is a revenue management method that involves managing and optimizing the allocation of inventory and pricing for a single segment or category of customers.
    /// This method allows businesses to set different booking limits and prices for a specific segment based on factors such as demand patterns, historical booking data, and market conditions.
    /// This is the most basic form of revenue management and is often used as a starting point for businesses looking to implement revenue management strategies.
    /// It can be effective for businesses with a relatively simple customer base and limited product offerings, but may not be sufficient for businesses with more complex customer segments and product portfolios.
    /// </summary>
    SingleSegmentControl,
    /// <summary>
    /// Origin-Destination Control is a revenue management method that involves managing and optimizing the allocation of inventory and pricing based on the specific origin and destination of a booking or purchase.
    /// This method allows businesses to set different booking limits and prices for various origin-destination pairs, taking into account factors such as demand patterns, historical booking data, and market conditions.
    /// Origin-Destination Control is particularly useful for businesses in the travel and transportation industry, where the origin and destination of a booking can significantly impact demand and pricing strategies since different routes may have varying levels of demand and competition.
    /// </summary>
    OriginDestinationControl,
    /// <summary>
    /// Virtual nesting control is a revenue management method that involves creating virtual nesting levels within a booking system to manage and optimize the allocation of inventory across different fare classes or segments.
    /// This method allows businesses to set different booking limits for various "virtual" fare classes or segments based on factors such as demand forecasts, historical booking patterns, and market conditions.
    /// "Virtual" refers to the fact that these nesting levels are not physically separate but are instead systematically defined to manage inventory and pricing strategies effectively.
    /// </summary>
    VirtualNestingControl,
    /// <summary>
    /// Bid Price Control is a revenue management method that involves setting a minimum price (bid price) for accepting bookings or purchases based on the expected revenue from those bookings. 
    /// The bid price is typically calculated using historical data, demand forecasts, and other relevant factors to optimize revenue while managing capacity effectively.
    /// This method allows businesses to make informed decisions about accepting or rejecting bookings based on their potential contribution to overall revenue, helping to maximize profitability while managing inventory and capacity constraints.
    /// However, it is important to note that bid price control can be complex to implement and may require sophisticated algorithms (ML and optimization) and data analysis to determine optimal bid prices for different segments and booking scenarios.
    /// </summary>
    BidPriceControl,
}
