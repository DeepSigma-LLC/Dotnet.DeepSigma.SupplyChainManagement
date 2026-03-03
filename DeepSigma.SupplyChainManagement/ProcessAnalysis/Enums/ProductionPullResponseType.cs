namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Specifies the available production pull response strategies used to manage inventory and fulfill customer demand.
/// </summary>
/// <remarks>This enumeration defines strategies for initiating production based on either anticipated demand
/// (fill-up pull system) or actual customer orders (make-to-order pull system). Selecting the appropriate strategy is
/// essential for balancing inventory levels, reducing waste, and meeting customer requirements efficiently.</remarks>
public enum ProductionPullResponseType
{
    /// <summary>
    /// Fill-up pull system is a production strategy where production is initiated based on actual demand, and the system is designed to fill up inventory levels to meet that demand.
    /// The upsteam processes produces goods to replenish what demand has consumed down stream.
    /// This approach helps to minimize inventory levels and reduce waste, while ensuring that products are available to meet customer demand in a timely manner.
    /// Also known as a "kanban", "make-to-stock", or "supermarket" pull system, this strategy focuses on maintaining sufficient inventory levels to meet anticipated customer demand, while minimizing excess inventory and associated costs.
    /// </summary>
    FillUpPullSystem,
    /// <summary>
    /// Make-to-order pull system is a production strategy where production is initiated only after receiving a customer order, ensuring that products are made to meet specific customer requirements.
    /// This approach helps to minimize inventory levels and reduce waste, while providing customized products to customers.
    /// </summary>
    MakeToOrderPullSystem,
}
