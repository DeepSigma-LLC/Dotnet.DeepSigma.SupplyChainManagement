
using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

namespace DeepSigma.SupplyChainManagement.ProcessAnalysis;

/// <summary>
/// Process Collection is a class that represents a collection of process elements and their associated characteristics, such as flow rate, capacity, processing time, and labor content.
/// This class provides methods to analyze the overall process by aggregating the characteristics of individual process elements, allowing for insights into bottlenecks, labor utilization, and overall process efficiency. It also includes properties to determine the flow rate, process capacity, and bottleneck constraints of the entire process based on the characteristics of its constituent elements.
/// </summary>
public class ProcessCollection
{
    /// <summary>
    /// ProcessElements is a collection of individual process elements that make up the overall process being analyzed. 
    /// Each process element represents a specific step or activity within the process, and contains information such as flow rate, capacity, processing time, and labor content. 
    /// This collection allows for the analysis of the entire process by aggregating the characteristics of each individual element, enabling insights into bottlenecks, labor utilization, and overall process efficiency.
    /// </summary>
    public List<ProcessElement> ProcessElements { get; set; } = [];

    /// <summary>
    /// ProductionLineType specifies the type of production line or process being analyzed, such as machine-paced line, continuous process, or other types of production systems.
    /// </summary>
    public ProductionLineType ProductionLineType { get; set; } = ProductionLineType.MachinePacedLine;

    /// <summary>
    /// Gets the flow rate of the entire process, calculated based on the current operational parameters.
    /// </summary>
    /// <remarks>The flow rate is dynamically determined by the method used to calculate it, which may involve
    /// various factors affecting the process. Ensure that the process is initialized before accessing this property to
    /// avoid unexpected results.</remarks>
    public decimal FlowRate => GetEntireProcessFlowRate();
    
    /// <summary>
    /// Gets the current processing capacity of the system as a decimal value.
    /// </summary>
    /// <remarks>The processing capacity reflects the system's ability to handle workloads at the present
    /// moment. This value may change based on real-time system metrics and is intended for monitoring or optimization
    /// purposes.</remarks>
    public decimal ProcessCapacity => GetProcessCapacity();

    /// <summary>
    /// Gets or sets the total amount of time that workers have spent on tasks.
    /// </summary>
    /// <remarks>This property reflects the cumulative time spent by all workers on their assigned tasks. It
    /// is useful for tracking overall productivity and performance metrics.</remarks>
    public decimal TotalWorkerTime {  get; set; }


    public ProcessConstraintType BottleneckConstraint => FlowRate < ProcessCapacity 
        ? ProcessConstraintType.DemandConstraint 
        : ProcessConstraintType.CapacityConstraint;

    /// <summary>
    /// Calculates the minimum flow rate across all process elements in the collection.
    /// </summary>
    /// <remarks>This method is useful for determining the bottleneck flow rate in a process, which can help
    /// assess overall process efficiency. It iterates through each process element to identify the lowest flow
    /// rate.</remarks>
    /// <returns>The minimum flow rate among all process elements. If no process elements are present, returns decimal.MaxValue.</returns>
    private decimal GetEntireProcessFlowRate()
    {
        decimal flowRate = decimal.MaxValue;
        foreach (ProcessElement processElement in ProcessElements)
        {
            flowRate = Math.Min(flowRate, processElement.FlowRate);
        }
        return flowRate;
    }

    /// <summary>
    /// Calculates the minimum capacity among all process elements in the collection.
    /// </summary>
    /// <remarks>This method is useful for determining the limiting factor in resource allocation scenarios.
    /// If the collection of process elements is empty, the returned value indicates that no capacity constraints are
    /// present.</remarks>
    /// <returns>The minimum capacity value of the process elements. If no process elements are present, returns <see
    /// cref="decimal.MaxValue"/>.</returns>
    private decimal GetProcessCapacity()
    {
        decimal capacity = decimal.MaxValue;
        foreach (ProcessElement processElement in ProcessElements)
        {
            capacity = Math.Min(capacity, processElement.Capacity);
        }
        return capacity;
    }

    /// <summary>
    /// Calculates the total labor content for all process elements in the collection.
    /// </summary>
    /// <remarks>The returned value represents the aggregate labor content for the entire process.</remarks>
    /// <returns>The sum of labor content values from each process element as a decimal. Returns 0 if the collection is empty.</returns>
    public decimal GetLaborContent()
    {
        decimal laborContent = 0;
        foreach (ProcessElement processElement in ProcessElements)
        {
            laborContent += processElement.LaborContent;
        }
        return laborContent;
    }

    /// <summary>
    /// Calculates the average labor utilization as a decimal value based on the total labor content and total worker
    /// time.
    /// </summary>
    /// <remarks>Ensure that the total worker time is not zero to avoid division by zero errors.</remarks>
    /// <returns>A decimal representing the average labor utilization. The value is calculated by dividing the total labor
    /// content by the total worker time.</returns>
    public decimal GetAverageLaborUtilization()
    {
        return GetLaborContent() / TotalWorkerTime;
    }

    /// <summary>
    /// Computes the labor idle time by subtracting the total labor content from the total worker time.
    /// </summary>
    /// <returns></returns>
    public decimal GetLaborIdleTime()
    {
        return TotalWorkerTime - GetLaborContent();
    }

    /// <summary>
    /// Identifies and returns the process element with the lowest flow rate from the collection of process elements.
    /// </summary>
    /// <remarks>This method iterates through all process elements to determine the bottleneck based on flow rate.</remarks>
    /// <returns>The process element with the lowest flow rate, or <see langword="null"/> if the collection contains no elements.</returns>
    public ProcessElement? GetBottleneckProcess()
    {
        ProcessElement? bottleneck = null;
        foreach (ProcessElement processElement in ProcessElements)
        {
            if (bottleneck == null || processElement.FlowRate < bottleneck.FlowRate)
            {
                bottleneck = processElement;
            }
        }
        return bottleneck;
    }

    /// <summary>
    /// Calculates the time it takes for a unit to go through the entire process when there are no other units in the system. 
    /// For machine-paced lines and continuous processes, this is determined by the bottleneck process. 
    /// For other types of production lines, it is the sum of the processing times of all process elements.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public TimeSpan TimeThroughAnEmptyProcess()
    {
        if(ProductionLineType == ProductionLineType.MachinePacedLine || ProductionLineType == ProductionLineType.ContinuousProcess)
        {
            ProcessElement? bottleneck = GetBottleneckProcess();
            return bottleneck != null ? bottleneck.ProcessingTime * ProcessElements.Count : throw new Exception("Bottleneck process not found.");
        }
        else
        {
            TimeSpan totalTime = TimeSpan.Zero;
            foreach (ProcessElement processElement in ProcessElements)
            {
                totalTime += processElement.ProcessingTime;
            }
            return totalTime;
        }
    }

    public TimeSpan TimeToFinishXUnitsWithAnEmptySystem(int x_number_of_units)
    {
        //return TimeThroughAnEmptyProcess() + (x_number_of_units - 1) / FlowRate);
        throw new NotImplementedException();
    }
}
