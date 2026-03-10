

namespace DeepSigma.SupplyChainManagement.InventoryManagement.Enums;

public enum InventoryStatus
{
    /// <summary>
    /// Stock out means that there is no inventory available to fulfill orders, while demands are still present.
    /// This can lead to lost sales and customer dissatisfaction.
    /// Note: The difference between stock out and out of stock is that stock out emphasizes the presence of demand without available inventory, while out of stock simply indicates the lack of inventory regardless of demand.
    /// </summary>
    Stockout,
    /// <summary>
    /// Out of stock means that there is no invetory available to fulfill orders.
    /// </summary>
    OutOfStock,
    /// <summary>
    /// In stock means that there is inventory available to fulfill orders.
    /// </summary>
    InStock,
    /// <summary>
    /// Backordered means that the inventory is temporarily unavailable, but orders can still be placed and will be fulfilled once the inventory is restocked.
    /// </summary>
    BackOrdered,
    /// <summary>
    /// On hand inventory means that the inventory is currently available and ready for fulfillment.
    /// </summary>
    OnHandInventory,
    /// <summary>
    /// On order inventory means that the inventory is currently on order and is expected to arrive soon, but is not yet available for fulfillment.
    /// Also known as "in transit inventory" or "pipeline inventory", this status indicates that the inventory is in the process of being replenished and will soon be available for fulfillment.
    /// </summary>
    OnOrderInventory,
}
