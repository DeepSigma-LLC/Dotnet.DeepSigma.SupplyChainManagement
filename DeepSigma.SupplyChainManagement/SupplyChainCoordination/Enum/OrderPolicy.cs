
namespace DeepSigma.SupplyChainManagement.SupplyChainCoordination.Enum;

/// <summary>
/// Defines the order policies that can be applied in supply chain coordination to manage inventory and demand effectively.
/// </summary>
public enum OrderPolicy
{
    /// <summary>
    /// Demand Pull: An order policy where production and inventory decisions are driven by actual customer demand rather than forecasts. 
    /// This approach helps to reduce excess inventory and improve responsiveness to market changes.
    /// Does not cause the bullwhip effect, since it is based on real demand rather than forecasts, which can lead to more accurate inventory management and reduced variability in the supply chain.
    /// </summary>
    DemandPull,
    /// <summary>
    /// Order Synchronization: An order policy that involves coordinating the timing and quantity of orders across different stages of the supply chain to minimize lead times, reduce inventory levels, and reduce costs.
    /// This approach can help to improve efficiency and responsiveness in the supply chain, but it requires effective communication and collaboration among supply chain partners to ensure that orders are synchronized effectively.
    /// While order synchronization can help to reduce inventory levels and improve efficiency, it can also lead to the bullwhip effect if not implemented properly. 
    /// </summary>
    OrderSynchronization,
    /// <summary>
    /// Order Batching: An order policy where orders are grouped together and processed in batches rather than individually.
    /// This approach can help to reduce transaction costs and improve efficiency, but it can also lead to increased lead times and inventory levels if not managed carefully.
    /// Order batching can contribute to the bullwhip effect because it can lead to larger and less frequent orders, which can create variability in demand and inventory levels throughout the supply chain.
    /// </summary>
    OrderBatching,
    /// <summary>
    /// Forward Buying: An order policy where customers or retailers purchase larger quantities of products than needed in the short term, often in response to promotions or anticipated price increases.
    /// This approach can lead to increased inventory levels and variability in demand, which can create challenges for supply chain management and contribute to the bullwhip effect if not managed carefully.
    /// </summary>
    ForwardBuying,
    /// <summary>
    /// Reactive Ordering: An order policy where orders are placed in response to actual demand rather than forecasts or planned schedules.
    /// This approach can help to reduce the risk of overproduction and excess inventory, but it may also lead to stockouts and increased lead times if not managed effectively.
    /// Reactive ordering can contribute to the bullwhip effect because it can lead to increased variability in demand and inventory levels, especially if there are delays in communication or if supply chain partners react to changes in demand in an uncoordinated manner.
    /// </summary>
    ReactiveOrdering,
    /// <summary>
    /// Shortage Gaming: An order policy where participants in the supply chain intentionally create or exaggerate shortages to gain a competitive advantage or manipulate market conditions.
    /// This approach can lead to significant disruptions in the supply chain, increased costs, and reduced trust among supply chain partners.
    /// Shortage gaming can contribute to the bullwhip effect because it can create artificial demand and inventory fluctuations, leading to increased variability and inefficiency in the supply chain.
    /// </summary>
    ShortageGaming,
}
