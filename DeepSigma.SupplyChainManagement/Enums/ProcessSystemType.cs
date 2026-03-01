
namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// ProcessSystemType is an enumeration that categorizes different types of process systems based on their buffering capabilities and how they handle flow rate reductions and losses during disruptions.
/// </summary>
public enum ProcessSystemType
{
    /// <summary>
    /// Represents a system that does not incorporate any buffering mechanisms to accommodate flow units during disruptions.
    /// Instead, this system experiences a reduction in flow rate when disruptions occur, but it does not necessarily result in losses of flow units.
    /// </summary>
    PureWaitingSystem,
    /// <summary>
    /// Represents a system that incorporates buffering mechanisms to accommodate flow units during disruptions, allowing for a reduction in flow rate without necessarily resulting in losses.
    /// This system classification does not allow for losses, but it can experience reductions in flow rate due to disruptions. 
    /// For example, this classification represents a system where there is a buffer that can hold flow units during disruptions, allowing the system to continue operating at a reduced flow rate without losing any flow units.
    /// </summary>
    BufferedWaitingSystem,
    /// <summary>
    /// Represents a system that provides unlimited (or effectively unlimited) buffering capacity to accommodate flow units during disruptions.
    /// However, even with near infinite buffering, the system can still experience losses due to flow unit perishability, obsolescence, or customer cancellation.
    /// </summary>
    InfiniteBufferedSystemWithLoss,
    /// <summary>
    /// Represents a system with a limited buffering capacity that can experience losses when the buffer is full or when disruptions occur, leading to a reduction in flow rate and potential loss of flow units.
    /// For example, this classification represents a system where there is a finite buffer that can hold a limited number of flow units.
    /// When the buffer reaches its capacity, any additional flow units that arrive will be immediately lost.
    /// </summary>
    LimitedBufferedSystemWithLoss,
    /// <summary>
    /// Represents a system that experiences losses without any buffering mechanisms in place, leading to a direct loss of flow units when disruptions occur.
    /// For example, this classification represents a system where if a resource is blocked or starved, the flow units are immediately lost instead of being buffered for later use.
    /// </summary>
    PureLossSystem,
}
