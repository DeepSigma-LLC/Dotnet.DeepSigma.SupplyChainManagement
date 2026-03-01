

namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// Specifies the five primary reasons for holding inventory within a supply chain or business operation.
/// </summary>
/// <remarks> This comes from De Groote (1994).
/// </remarks>
public enum ReasonsToHoldInventory
{
    /// <summary>
    /// Pipeline Inventory, also known as "In-Transit Inventory," refers to the stock that is currently being transported between different locations in the supply chain, such as from a supplier to a manufacturer or from a manufacturer to a retailer. 
    /// This type of inventory is essential for maintaining a continuous flow of goods and ensuring that products are available when needed, despite the time it takes for transportation. 
    /// Managing pipeline inventory effectively can help reduce lead times and improve overall supply chain efficiency.
    /// </summary>
    PipelineInventory,
    /// <summary>
    /// Seasonal Inventory is stock that is accumulated in anticipation of predictable fluctuations in demand due to seasonal factors, such as holidays, weather changes, or special events.
    /// </summary>
    SeasonalInventory,
    /// <summary>
    /// Cycle Inventory, also known as "Working Inventory," is the stock that is regularly used to meet ongoing demand during normal business operations.
    /// It is the inventory that is consumed and replenished in a continuous cycle, and it is essential for maintaining smooth production and sales processes.
    /// For example, a single shipment of raw materials to a factory may be more than what is needed for a single production run, so the excess inventory is held as cycle inventory to ensure that production can continue without interruption until the next shipment arrives.
    /// </summary>
    CycleInventory,
    /// <summary>
    /// Decoupling Inventory, also known as "Buffer Inventory," is the stock that is held to decouple or separate different stages of a production process or supply chain.
    /// Different stages of a process may have varying production rates, lead times, or demand patterns, and decoupling inventory helps to ensure that one stage can continue to operate even if another stage experiences delays or disruptions.
    /// </summary>
    DecouplingInventory,
    /// <summary>
    /// Safety Inventory is the stock that is held as a precautionary measure to protect against uncertainties in demand.
    /// </summary>
    SafetyInventory,
}
