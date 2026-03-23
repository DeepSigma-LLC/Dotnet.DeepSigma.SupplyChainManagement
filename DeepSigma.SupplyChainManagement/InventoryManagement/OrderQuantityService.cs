using DeepSigma.General.Extensions;
using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

namespace DeepSigma.SupplyChainManagement.InventoryManagement;

/// <summary>
/// Order quantity service provides methods for calculating optimal batch sizes and economic order quantities based on various factors such as flow rate, setup time, processing time, setup cost, and holding cost. These calculations can help organizations optimize their inventory management and production processes by determining the most efficient order quantities to minimize costs and improve throughput.
/// </summary>
public static class OrderQuantityService
{
    /// <summary>
    /// Recommended Batch Size calculates the optimal batch size for a production process based on the flow rate, setup time, and processing time. 
    /// The recommended batch size can help improve efficiency and reduce costs in manufacturing operations by balancing the trade-off between setup time and processing time.
    /// </summary>
    /// <param name="flow_rate"></param>
    /// <param name="setup_time"></param>
    /// <param name="processing_time"></param>
    /// <returns></returns>
    public static decimal RecommendedBatchSize(decimal flow_rate, decimal setup_time, decimal processing_time)
    {
        decimal batch_size = (flow_rate * setup_time) / (1 - flow_rate * processing_time);
        return batch_size;
    }

    /// <summary>
    /// Economic order quantity calculates the optimal order quantity for inventory management based on the setup cost, flow rate, and holding cost.
    /// </summary>
    /// <param name="setup_cost"></param>
    /// <param name="flow_rate"></param>
    /// <param name="holding_cost"></param>
    /// <returns></returns>
    public static decimal EconomicOrderQuantity(decimal setup_cost, decimal flow_rate, decimal holding_cost)
    {
        decimal result = 2 * setup_cost * flow_rate * (1/holding_cost);
        return Math.Sqrt(result);
    }

    /// <summary>
    /// Optimal Batch Size determines the optimal batch size for a production process by considering both the economic order quantity and the recommended batch size.
    /// </summary>
    /// <param name="setup_time"></param>
    /// <param name="setup_cost"></param>
    /// <param name="flow_rate"></param>
    /// <param name="processing_time"></param>
    /// <param name="holding_cost"></param>
    /// <param name="resource_with_setup_time_is_bottleneck"></param>
    /// <returns></returns>
    public static decimal OptimalBatchSize(ProcessConstraintType constraintType, decimal setup_time, decimal setup_cost, decimal flow_rate, decimal processing_time, decimal holding_cost, bool resource_with_setup_time_is_bottleneck)
    {
        decimal economic_order_quanity = EconomicOrderQuantity(setup_cost, flow_rate, holding_cost);
        decimal recommended_batch_size = RecommendedBatchSize(flow_rate, setup_time, processing_time);

        if (setup_time == 0) return economic_order_quanity; // If there is no setup time, we can just use EOQ to determine the optimal batch size since there is no need to consider the trade off between setup time and processing time.
        if (setup_cost == 0) return recommended_batch_size; // If there is no setup cost, we can just use the recommended batch size to determine the optimal batch size since there is no need to consider the trade off between setup time and processing time.
        if (!resource_with_setup_time_is_bottleneck) return economic_order_quanity;

        // If the resource with setup time is the bottleneck, we should choose the optimal batch size that optimizes for flow through the bottleneck resource (assuming we are capacity constrained).
        return constraintType switch
        {
            ProcessConstraintType.CapacityConstraint => recommended_batch_size,
            ProcessConstraintType.DemandConstraint => economic_order_quanity,
            _ => throw new ArgumentException($"Unsupported constraint type: {constraintType}"),
        };
    }

    /// <summary>
    /// Economic Order Quantity Cost calculates the total cost associated with ordering and holding inventory based on the economic order quantity, setup cost, flow rate, and inventory holding cost. This calculation can help organizations understand the trade-offs between ordering costs and holding costs to optimize their inventory management strategies.
    /// </summary>
    /// <param name="setup_cost"></param>
    /// <param name="flow_rate"></param>
    /// <param name="inventory_holding_cost"></param>
    /// <returns></returns>
    public static decimal EconomicOrderQuantityCost(decimal setup_cost, decimal flow_rate, decimal inventory_holding_cost)
    {
        decimal intermediate = 2 * setup_cost * flow_rate * inventory_holding_cost;
        return Math.Sqrt(intermediate);
    }

    public static decimal EconomicOrderQuantityCostPerUnit(decimal setup_cost, decimal flow_rate, decimal inventory_holding_cost)
    {
        decimal intermediate = 2 * setup_cost * inventory_holding_cost * (1/flow_rate);
        return Math.Sqrt(intermediate);
    }
}
