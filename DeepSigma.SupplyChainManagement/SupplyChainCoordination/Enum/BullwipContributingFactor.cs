
namespace DeepSigma.SupplyChainManagement.SupplyChainCoordination.Enum;

/// <summary>
/// Bullwhip Effect Contributing Factors: An enumeration that identifies the various factors that can contribute to the bullwhip effect in supply chain management.
/// Note: With a perfect demand-pull order policy (also known as a pull-based system), the bullwhip effect is eliminated because production and inventory decisions are based on actual customer demand rather than forecasts or variability in ordering patterns. 
/// In a demand-pull system, each stage of the supply chain responds directly to the demand from the next stage, which helps to reduce variability and improve responsiveness throughout the supply chain.
/// </summary>
public enum BullwipContributingFactor
{
    /// <summary>
    /// Order Synchronization: Occurs when supply chain partners unintentionally synchronize their ordering patterns, leading to amplified demand variability and inventory fluctuations throughout the supply chain.
    /// For example, producers may often place orders at the end of the month to meet sales targets, which can lead to synchronized ordering patterns and increased variability in demand and inventory levels throughout the supply chain.
    /// This phenomenon can exacerbate the bullwhip effect, where small changes in demand at the consumer level lead to larger and larger fluctuations in demand at the wholesale, distributor, and manufacturer levels.
    /// </summary>
    OrderSynchronization,
    /// <summary>
    /// Order Batching: Orders are placed in batches rather than in response to actual demand, which can lead to increased variability in demand and inventory levels throughout the supply chain.
    /// Orders are often placed in batches to take advantage of economies of scale, reduce ordering costs, or meet minimum order quantities. 
    /// However, this practice can lead to increased variability in demand and inventory levels throughout the supply chain, as it can create artificial demand patterns and lead to overproduction or excess inventory if not managed carefully.
    /// This phenomenon can exacerbate the bullwhip effect, where small changes in demand at the consumer level lead to larger and larger fluctuations in demand at the wholesale, distributor, and manufacturer levels.
    /// </summary>
    OrderBatching,
    /// <summary>
    /// Forward Buying: Supply chain partners purchase more inventory than needed in anticipation of future demand or to take advantage of discounts, which can lead to increased variability in demand and inventory levels throughout the supply chain.
    /// Forward buying can occur when supply chain partners expect future price increases, anticipate shortages, or want to take advantage of volume discounts.
    /// This phenomenon can exacerbate the bullwhip effect, where small changes in demand at the consumer level lead to larger and larger fluctuations in demand at the wholesale, distributor, and manufacturer levels.
    /// </summary>
    ForwardBuying,
    /// <summary>
    /// Reactive Ordering: Refers to the practice of placing orders based on recent demand patterns or inventory levels rather than on actual customer demand or long-term forecasts.
    /// This approach can lead to increased variability in demand and inventory levels throughout the supply chain, as it can create a feedback loop where each stage of the supply chain reacts to the actions of the previous stage, leading to amplified fluctuations in demand and inventory levels.
    /// This phenomenon can exacerbate the bullwhip effect, where small changes in demand at the consumer level lead to larger and larger fluctuations in demand at the wholesale, distributor, and manufacturer levels.
    /// Furthermore, humans tend to overreact to changes in demand, which can exacerbate the bullwhip effect. 
    /// For example, if a retailer experiences a sudden increase in demand for a product, they may place a larger order with their supplier than necessary, which can lead to increased variability in demand and inventory levels throughout the supply chain.
    /// </summary>
    ReactiveOrdering,
    /// <summary>
    /// Shortage Gaming: Refers to the practice of supply chain partners intentionally creating artificial demand or inventory fluctuations in response to perceived shortages or supply disruptions.
    /// This is often done to gain a competitive advantage, secure better pricing, or ensure access to limited resources.
    /// However, it is also not always intentional, as it can occur when supply chain partners react to perceived shortages or supply disruptions by placing larger orders than necessary, which can lead to increased variability.
    /// Shortage gaming can contribute to the bullwhip effect because it can create artificial demand and inventory fluctuations, leading to increased variability and inefficiency in the supply chain.
    /// To counteract shortage gaming, supply chain partners can implement allocation policies that prioritize orders based on actual demand and inventory levels, rather than on perceived shortages or supply disruptions.
    /// This can sometime result in a more equitable distribution of resources and help to reduce the variability and inefficiency caused by shortage gaming.
    /// However, it can also create phantoms orders, which are orders that are placed but may be canceled or modified later, leading to increased variability and inefficiency in the supply chain as supply chain partners react to the perceived demand and inventory levels.
    /// </summary>
    ShortageGaming,
}
