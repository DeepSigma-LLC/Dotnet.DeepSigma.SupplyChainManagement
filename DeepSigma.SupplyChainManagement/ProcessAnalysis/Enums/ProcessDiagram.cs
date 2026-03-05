namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// ProcessDiagram specifies the types of diagrams used to visually represent and analyze processes, workflows, and dependencies within a system or project.
/// </summary>
public enum ProcessDiagram
{
    /// <summary>
    /// Process Flow Diagram is a visual representation of the steps involved in a process, showing the flow of materials, information, and activities from start to finish.
    /// </summary>
    ProcessFlowDiagram,
    /// <summary>
    /// Dependency Matrix is a tool used to identify and analyze the dependencies between different elements of a process or system.
    /// </summary>
    DependencyMatrix,
    /// <summary>
    /// Activity on Node Diagram is a visual representation of a project's activities and their dependencies, used for project scheduling and management.
    /// </summary>
    ActivityOnNodeDiagram,
    /// <summary>
    /// Gantt Chart is a type of bar chart that represents a project schedule, showing the start and finish dates of various elements of a project.
    /// </summary>
    GanttChart,
    /// <summary>
    /// Represents an Ishikawa diagram, also known as a fishbone diagram, used for identifying and organizing potential
    /// causes of a problem.
    /// </summary>
    /// <remarks>This diagram is commonly used in quality management and process improvement to visually
    /// display the relationship between a problem and its potential causes. It helps teams systematically explore the
    /// various factors contributing to an issue, facilitating root cause analysis.</remarks>
    IshikawaDiagram,
    /// <summary>
    /// Actual Verse Forecast Chart is a visual representation that compares actual performance data against forecasted data over a specific period.
    /// Typicall used in business and project management, this chart helps to identify trends, variances, and areas for improvement by highlighting discrepancies between expected outcomes and actual results.
    /// </summary>
    ActualVerseForecastChart,
    /// <summary>
    /// Parento Chart is a type of bar chart that represents the frequency or impact of different causes or factors, with the bars arranged in descending order to highlight the most significant contributors.
    /// Typically used in quality control and process improvement, the Pareto Chart helps identify the "vital few" causes that contribute to the majority of problems, following the Pareto principle (80/20 rule).
    /// </summary>
    ParetoChart,
    /// <summary>
    /// Control Chart is a graphical tool used to monitor and control a process by plotting data points over time and identifying any variations or trends that may indicate a problem.
    /// It helps in distinguishing between common cause variation (inherent to the process) and special cause variation (due to specific factors), enabling timely corrective actions.
    /// </summary>
    ControlChart,
    /// <summary>
    /// p-Chart is a type of control chart used to monitor the proportion of defective items in a process over time.
    /// It is commonly used in quality control to track the percentage of nonconforming units as a proportion (percentage) in a production process, helping to identify trends and variations that may indicate issues with the process.
    /// </summary>
    PChart,
    /// <summary>
    /// Customer Value Curve is a visual representation that illustrates the relationship between the value provided to customers and the cost of delivering that value.
    /// It helps organizations understand how their products or services create value for customers and identify opportunities for improvement or differentiation.
    /// </summary>
    CustomerValueCurve,
    /// <summary>
    /// Return on Invested Capital (ROIC) Tree is a visual representation that breaks down the components of ROIC, such as net operating profit after tax (NOPAT) and invested capital, to analyze the drivers of return on invested capital and identify areas for improvement in financial performance.
    /// ROIC Tree helps businesses understand how different factors contribute to their overall return on invested capital and make informed decisions to optimize their financial performance and create value for shareholders.
    /// </summary>
    ReturnOnInvestedCapitalTree
}
