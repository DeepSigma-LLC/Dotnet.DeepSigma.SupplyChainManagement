namespace DeepSigma.SupplyChainManagement.BusinessInnovation.Enums;

/// <summary>
/// Specifies the types of supply-side innovations available for modeling in supply chain management scenarios.
/// Business models will only be successful if they can effectively match supply and demand.
/// Innovating on the demand side is crucial for understanding customer needs and preferences, while innovating on the supply side is essential for optimizing production processes and delivering value to customers.
/// A unique customer value curve is only a viable strategy if the company can effectively coordinate the supply side to deliver the value promised to customers.
/// </summary>
public enum SupplySideInnovation
{
    /// <summary>
    /// Process timing innovation refers to the various ways in which companies can innovate to optimize the timing of their production processes.
    /// This can include strategies such as just-in-time production, demand forecasting, and production scheduling.
    /// By innovating in process timing, companies can reduce lead times, minimize inventory costs, and improve overall efficiency.
    /// </summary>
    ProcessTiming,
    /// <summary>
    /// Process location innovation refers to the various ways in which companies can innovate to optimize the location of their production processes.
    /// This can include strategies such as relocating facilities, optimizing supply chain networks, and leveraging geographic advantages.
    /// By innovating in process location, companies can reduce costs, improve efficiency, and enhance responsiveness to market demands.
    /// </summary>
    ProcessLocation,
    /// <summary>
    /// Process standardization innovation refers to the various ways in which companies can innovate to standardize their production processes.
    /// This can include strategies such as implementing best practices, adopting industry standards, and streamlining operations.
    /// By innovating in process standardization, companies can achieve consistency, reduce variability, and improve overall quality.
    /// </summary>
    ProcessStandardization,
}
