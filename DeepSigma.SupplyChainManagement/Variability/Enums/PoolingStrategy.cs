namespace DeepSigma.SupplyChainManagement.Variability.Enums;

/// <summary>
/// Pooling strategies are used to reduce variability in supply chain management by grouping similar products, locations, or distribution processes together.
/// This can help to optimize inventory levels, reduce lead times, and improve overall efficiency.
/// The specific pooling strategy used will depend on the characteristics of the supply chain and the goals of the organization.
/// </summary>
public enum PoolingStrategy
{
    /// <summary>
    /// Location pooling involves grouping similar locations together to share inventory and resources. 
    /// This can help to reduce lead times and improve service levels by allowing for more efficient distribution of products.
    /// </summary>
    LocationPooling,
    /// <summary>
    /// Product pooling often involves creating a common product or component that can be used across multiple products or product lines.
    /// This can help to reduce costs and improve efficiency by standardizing components and processes.
    /// </summary>
    ProductPooling,
    /// <summary>
    /// Consolidated distribution involves combining shipments from multiple locations or suppliers into a single shipment.
    /// Often this involves using a distribution center or hub to consolidate shipments before they are sent to customers or retail locations.
    /// This can help to reduce overall transportation costs and improve delivery reliability by increasing the number of shipments and reducing the distance traveled for each shipment.
    /// This is a form of lead time pooling, where the lead time for delivering a product is reduced by consolidating shipments and reducing the distance traveled for each shipment.
    /// </summary>
    ConsolidatedDistribution,
    /// <summary>
    /// Delayed differentiation involves postponing the final production or customization of a product until customer demand is known.
    /// This can help to reduce inventory costs and improve responsiveness to customer demand.
    /// This is a form of lead time pooling, where the lead time for producing a product is reduced by delaying the final production steps until customer demand is known.
    /// </summary>
    DelayedDifferentiation
}
