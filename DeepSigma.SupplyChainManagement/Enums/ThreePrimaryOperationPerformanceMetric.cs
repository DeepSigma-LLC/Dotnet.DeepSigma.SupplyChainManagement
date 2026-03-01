

namespace DeepSigma.SupplyChainManagement.Enums;

/// <summary>
/// The three primary operation performance metrics are flow rate, flow time, and inventory. 
/// These metrics are used to evaluate the performance of a production process and identify areas for improvement. 
/// By analyzing these metrics, organizations can optimize their production processes and improve overall efficiency.
/// </summary>
public enum ThreePrimaryOperationPerformanceMetric
{
    /// <summary>
    /// Flow rate measures the number of units produced per unit of time, flow time measures the total time it takes for a unit to move through the entire production process, and inventory measures the amount of work-in-progress or finished goods that are held in stock at any given time.
    /// </summary>
    FlowRate,
    /// <summary>
    /// Flow time measures the total time it takes for a unit to move through the entire production process, and inventory measures the amount of work-in-progress or finished goods that are held in stock at any given time.
    /// </summary>
    FlowTime,
    /// <summary>
    /// Inventory measures the amount of work-in-progress or finished goods that are held in stock at any given time.
    /// </summary>
    Inventory,
}
