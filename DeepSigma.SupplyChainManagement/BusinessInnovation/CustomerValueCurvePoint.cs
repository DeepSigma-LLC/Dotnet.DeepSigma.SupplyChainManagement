using DeepSigma.SupplyChainManagement.BusinessInnovation.Enums;

namespace DeepSigma.SupplyChainManagement.BusinessInnovation;

/// <summary>
/// Customer Value Curve Point represents a specific point on the Customer Value Curve, which illustrates the relationship between the value provided to customers and the cost of delivering that value.
/// Plotting different demand side innovations on the curve helps organizations understand how their products or services create value for customers and identify opportunities for improvement or differentiation versus competitors. 
/// </summary>
public class CustomerValueCurvePoint
{
    /// <summary>
    /// Demand side innovation refers to the various ways in which companies can innovate to meet the changing needs and preferences of customers.
    /// </summary>
    public DemandSideInnovation Innovation { get; set; }

    /// <summary>
    /// Value (or score) indicates the level of value provided to customers for a specific demand side innovation.
    /// </summary>
    public double Value { get; set; }


    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj == null) return false; 
        return obj is CustomerValueCurvePoint other && Innovation == other.Innovation;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => Innovation.GetHashCode();
}

