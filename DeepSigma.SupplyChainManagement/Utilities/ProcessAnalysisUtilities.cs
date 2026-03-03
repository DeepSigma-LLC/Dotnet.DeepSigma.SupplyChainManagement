using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

namespace DeepSigma.SupplyChainManagement.Utilities;

/// <summary>
///  Utilities for process analysis, including calculations for inventory, flow rate, flow time, capacity, utilization, and other key performance metrics used in evaluating and optimizing production processes. These utilities can help organizations analyze their operations, identify bottlenecks, and make informed decisions to improve efficiency and throughput.
/// </summary>
public static class ProcessAnalysisUtilities
{
    public static decimal ComputeInventory(decimal cumulative_inflow, decimal cumulative_outflow) => cumulative_inflow - cumulative_outflow;

    /// <summary>
    /// Calculates the average inventory based on the average flow rate and average flow time. (Little's Law)
    /// </summary>
    /// <param name="average_flow_rate">The average rate at which items flow through the inventory, expressed as a decimal value. Must be non-negative.</param>
    /// <param name="average_flow_time">The average time period over which the flow rate is measured, expressed as a decimal value. Must be
    /// non-negative.</param>
    public static decimal AverageInventory(decimal average_flow_rate, decimal average_flow_time) => average_flow_rate * average_flow_time;

    public static decimal ComputeFlowRate(decimal inventory, decimal flow_time) => flow_time == 0 ? decimal.MaxValue : inventory / flow_time; // Avoid division by zero, implies infinite flow rate

    public static decimal ComputeFlowTime(decimal inventory, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : inventory / flow_rate; // Avoid division by zero, implies infinite flow time
    /// <summary>
    /// 
    /// </summary>
    /// <param name="flow_time"></param>
    /// <returns></returns>
    public static decimal ComputeInventoryTurns(decimal flow_time) => flow_time == 0 ? decimal.MaxValue : 1 / flow_time; // Avoid division by zero, implies infinite inventory turns

    public static decimal ComputePerUnitInventoryCost(decimal annual_inventory_holding_cost, decimal annual_inventory_turns) => annual_inventory_turns == 0 ? decimal.MaxValue : annual_inventory_holding_cost / annual_inventory_turns; // Avoid division by zero, implies infinite per unit inventory cost

    public static decimal GetProcessCapacity(params decimal[] stage_capacities) => stage_capacities.Min();

    public static decimal GetFlowRate(decimal available_input, decimal demand, decimal process_capacity) => new[] { available_input, demand, process_capacity }.Min();

    public static decimal TimeToProduce(decimal demand, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : demand / flow_rate; // Avoid division by zero, implies infinite time to produce
    public static decimal ComputeUtilization(decimal flow_rate, decimal process_capacity) => process_capacity == 0 ? 0 : flow_rate / process_capacity; // Avoid division by zero, implies no utilization

    public static decimal ComputeBaseLevelExcessCapacity(decimal process_capacity, decimal flow_rate) => process_capacity - flow_rate;

    public static decimal ComputeImpliedUtilization(decimal demand, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : demand / flow_rate; // Avoid division by zero, implies infinite implied utilization

    public static decimal ComputeDirectLaborCost(decimal total_wages_per_unit_time, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : total_wages_per_unit_time / flow_rate;

    public static decimal ComputeAverageLaborUtiltization(decimal labor_content, decimal flow_rate, decimal number_of_workers) => number_of_workers == 0 ? 0 : (labor_content * flow_rate) / number_of_workers; // Avoid division by zero, implies no labor utilization
    public static decimal ComputeCapacityGivenBatchSize(decimal batch_size, decimal setup_time, decimal processing_time) => ((setup_time + batch_size * processing_time) == 0) ? decimal.MaxValue : batch_size / (setup_time + batch_size * processing_time);

    /// <summary>
    /// Determines whether to increase batch size based on the type of bottleneck constraint. 
    /// If the bottleneck is demand constrained, increasing batch size may not be effective in increasing throughput since the demand is the limiting factor. 
    /// However, if the bottleneck is supply constrained, increasing batch size can help increase throughput by allowing more flow units to be processed at the bottleneck, thus utilizing excess capacity and improving overall flow through the process.
    /// </summary>
    /// <param name="bottleneck_constraint"></param>
    /// <returns></returns>
    public static bool IncreaseBatchSize(ProcessConstraintType bottleneck_constraint)
    {
        // If not demand constrained, we are supply constrained at the bottleneck.
        // Therefore, we should increase the batch size to increase throughput sice we can squeeze out excess capacity at the bottleneck but increasing supply of flow units with large batches.
        return bottleneck_constraint == ProcessConstraintType.DemandConstraint ? false : true; 
    }
}
