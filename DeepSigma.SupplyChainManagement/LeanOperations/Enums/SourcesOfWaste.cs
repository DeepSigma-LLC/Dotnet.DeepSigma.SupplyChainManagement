namespace DeepSigma.SupplyChainManagement.LeanOperations.Enums;

/// <summary>
/// Eight sources of waste in supply chain management, commonly referred to as the "8 Wastes," are categories of inefficiencies that can occur in various processes within the supply chain. These wastes represent activities or resources that do not add value to the customer and can lead to increased costs, reduced productivity, and decreased customer satisfaction. Identifying and eliminating these wastes is a key principle of lean manufacturing and supply chain management, aimed at improving efficiency and delivering greater value to customers.
/// </summary>
public enum SourcesOfWaste
{
    /// <summary>
    /// Overproduction refers to producing more products than are needed or producing them before they are needed. 
    /// This can lead to excess inventory, increased storage costs, and the risk of obsolescence.
    /// </summary>
    Overproduction,
    /// <summary>
    /// Waiting refers to the time when resources are idle due to delays, bottlenecks, or dependencies. 
    /// This can result in lost productivity and increased lead times.
    /// </summary>
    Waiting,
    /// <summary>
    /// Transportation refers to the movement of materials, products, or information that does not add value to the customer. 
    /// Excessive transportation can lead to increased costs, longer lead times, and potential damage to products.
    /// </summary>
    Transportation,
    /// <summary>
    /// Overprocessing refers to performing more work or adding more features than what is required by the customer. 
    /// This can result in wasted time, effort, and resources.
    /// </summary>
    Overprocessing,
    /// <summary>
    /// Inventory refers to excess products or materials that are not being processed or used. 
    /// This can lead to increased storage costs, obsolescence, and tied-up capital.
    /// </summary>
    Inventory,
    /// <summary>
    /// Motion refers to unnecessary movement of people, equipment, or information that does not add value to the customer.
    /// This can lead to increased fatigue, reduced productivity, and potential safety hazards.
    /// </summary>
    Motion,
    /// <summary>
    /// Rework refers to the effort required to correct defects or errors in products or processes.
    /// This can result in wasted time, materials, and labor.
    /// </summary>
    Rework,
    /// <summary>
    /// HumanIntellect refers to the underutilization of people's skills, knowledge, and creativity.
    /// This can lead to missed opportunities for improvement and innovation.
    /// </summary>
    HumanIntellect,
}
