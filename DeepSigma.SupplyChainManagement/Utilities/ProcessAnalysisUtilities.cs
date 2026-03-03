using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;
using System.ComponentModel.Design;

namespace DeepSigma.SupplyChainManagement.Utilities;

internal class ProcessAnalysisUtilities
{
    public decimal ComputeInventory(decimal cumulative_inflow, decimal cumulative_outflow) => cumulative_inflow - cumulative_outflow;

    /// <summary>
    /// Calculates the average inventory based on the average flow rate and average flow time. (Little's Law)
    /// </summary>
    /// <param name="average_flow_rate">The average rate at which items flow through the inventory, expressed as a decimal value. Must be non-negative.</param>
    /// <param name="average_flow_time">The average time period over which the flow rate is measured, expressed as a decimal value. Must be
    /// non-negative.</param>
    public decimal AverageInventory(decimal average_flow_rate, decimal average_flow_time) => average_flow_rate * average_flow_time;

    public decimal ComputeFlowRate(decimal inventory, decimal flow_time) => flow_time == 0 ? decimal.MaxValue : inventory / flow_time; // Avoid division by zero, implies infinite flow rate

    public decimal ComputeFlowTime(decimal inventory, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : inventory / flow_rate; // Avoid division by zero, implies infinite flow time

    /// <summary>
    /// 
    /// </summary>
    /// <param name="flow_time"></param>
    /// <returns></returns>
    public decimal ComputeInventoryTurns(decimal flow_time) => flow_time == 0 ? decimal.MaxValue : 1 / flow_time; // Avoid division by zero, implies infinite inventory turns

    public decimal ComputePerUnitInventoryCost(decimal annual_inventory_holding_cost, decimal annual_inventory_turns) => annual_inventory_turns == 0 ? decimal.MaxValue : annual_inventory_holding_cost / annual_inventory_turns; // Avoid division by zero, implies infinite per unit inventory cost

    public decimal GetProcessCapacity(params decimal[] stage_capacities) => stage_capacities.Min();

    public decimal GetFlowRate(decimal available_input, decimal demand, decimal process_capacity) => new[] { available_input, demand, process_capacity }.Min();

    public decimal TimeToProduce(decimal demand, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : demand / flow_rate; // Avoid division by zero, implies infinite time to produce

    public decimal ComputeUtilization(decimal flow_rate, decimal process_capacity) => process_capacity == 0 ? 0 : flow_rate / process_capacity; // Avoid division by zero, implies no utilization

    public decimal ComputeBaseLevelExcessCapacity(decimal process_capacity, decimal flow_rate) => process_capacity - flow_rate;

    public decimal ComputeImpliedUtilization(decimal demand, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : demand / flow_rate; // Avoid division by zero, implies infinite implied utilization

    public decimal ComputeDirectLaborCost(decimal total_wages_per_unit_time, decimal flow_rate) => flow_rate == 0 ? decimal.MaxValue : total_wages_per_unit_time / flow_rate;

    public decimal ComputeAverageLaborUtiltization(decimal labor_content, decimal flow_rate, decimal number_of_workers) => number_of_workers == 0 ? 0 : (labor_content * flow_rate) / number_of_workers; // Avoid division by zero, implies no labor utilization

    public decimal ComputeCapacityGivenBatchSize(decimal batch_size, decimal setup_time, decimal processing_time) => ((setup_time + batch_size * processing_time) == 0) ? decimal.MaxValue : batch_size / (setup_time + batch_size * processing_time);

    public bool IncreaseBatchSize(ProcessConstraintType bottleneck_constraint)
    {
        // If not demand constrained, we are supply constrained at the bottleneck.
        // Therefore, we should increase the batch size to increase throughput sice we can squeeze out excess capacity at the bottleneck but increasing supply of flow units with large batches.
        return bottleneck_constraint == ProcessConstraintType.DemandConstraint ? false : true; 
    }


    /// <summary>
    /// The coefficient of variation is a measure of relative variability that is calculated as the ratio of the standard deviation to the mean.
    /// </summary>
    /// <param name="standard_deviation">The standard deviation of the data set.</param>
    /// <param name="mean">The mean of the data set.</param>
    /// <returns>The coefficient of variation.</returns>
    public decimal ComputeCoefficientOfVariation(decimal standard_deviation, decimal mean) => mean == 0 ? decimal.MaxValue : standard_deviation / mean; // Avoid division by zero, implies infinite coefficient of variation

 
}
