
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// ProductionResponseType is an enumeration that categorizes the two primary types of production response strategies in supply chain management: push systems and pull systems.
/// </summary>
public enum ProductionResponseType
{
    /// <summary>
    /// Push systems are characterized by the production and movement of goods based on forecasted demand. 
    /// In a push system, production is initiated based on anticipated customer demand, and goods are produced and moved through the supply chain according to a predetermined schedule. 
    /// This approach can lead to overproduction and excess inventory if forecasts are inaccurate, but it allows for better control over production processes and can be more efficient in certain scenarios where demand is relatively stable.
    /// </summary>
    PushSystem,
    /// <summary>
    /// Pull systems are characterized by the production and movement of goods based on actual demand. 
    /// In a pull system, production is initiated in response to customer orders or consumption, ensuring that goods are produced and moved through the supply chain only when needed. 
    /// This approach helps minimize inventory levels and reduce waste, but it requires a responsive and flexible production system to meet fluctuating demand.
    /// </summary>
    PullSystem,
}
