# DeepSigma.SupplyChainManagement

A C#/.NET library for common supply chain, inventory, process analysis, quality control, and variability calculations.

This package is designed for analysts, engineers, and developers who want reusable formulas and lightweight domain models for operational decision-making in manufacturing, logistics, and supply chain workflows.

## Features

* **Newsvendor modeling**

  * Critical ratio
  * Optimal order quantity
  * Expected sales, leftover inventory, revenue, cost, and profit
  * In-stock and stockout probabilities
  * Quantity required to hit a target service level
  * Forecast calibration via actual-to-forecast ratio

* **Inventory management**

  * Recommended batch size
  * Economic order quantity (EOQ)
  * EOQ cost
  * Setup and inventory cost rate calculations
  * Batch-size decisions based on process constraints

* **Process analysis**

  * Inventory, flow rate, and flow time calculations
  * Capacity and bottleneck-oriented helpers
  * Utilization and implied utilization
  * Labor utilization
  * Little’s Law helpers
  * Capacity calculations with setup time and batch size

* **Quality control**

  * Process capability index (Cp)
  * Defect probability
  * Control limits
  * Yield calculations
  * Flow-unit requirements to hit a target yield

* **Variability / queueing-style utilities**

  * Approximate wait time calculations
  * Throughput-loss style helpers
  * Production-model selection support

* **Supply chain coordination**

  * Buy-back price calculation for coordinating retailer/manufacturer incentives

## Repository structure

```text
DeepSigma.SupplyChainManagement/
├── DeepSigma.SupplyChainManagement/         # Main library
│   ├── InventoryManagement/
│   ├── ProcessAnalysis/
│   ├── SupplyChainCoordination/
│   ├── Utilities/
│   ├── Variability/
│   ├── Newsvendor.cs
│   └── Terminology.cs
└── DeepSigma.SupplyChainManagement.Test/    # xUnit test project

Target framework

This library currently targets:

.NET 10

Getting started
Clone the repository
git clone https://github.com/DeepSigma-LLC/Dotnet.DeepSigma.SupplyChainManagement.git
cd Dotnet.DeepSigma.SupplyChainManagement
Build
dotnet build
Run tests
dotnet test
Usage
Newsvendor example
using DeepSigma.SupplyChainManagement;

var newsvendor = new Newsvendor
{
    Mean = 3192m,
    StandardDeviation = 1181m,
    OverageCost = 20m,
    UnderageCost = 80m,
    SelectedValue = 3500m,
    Price = 120m,
    Cost = 40m,
    SalvageValue = 20m,
    ActualDemand = 3776.265m
};

Console.WriteLine($"Critical Ratio: {newsvendor.CriticalRatio}");
Console.WriteLine($"Optimal Quantity: {newsvendor.OptimalQuantity}");
Console.WriteLine($"Expected Profit: {newsvendor.ExpectedProfit}");
Console.WriteLine($"In-stock Probability: {newsvendor.GetInstockProbability(3500m)}");
Inventory management example
using DeepSigma.SupplyChainManagement.InventoryManagement;

decimal setupCost = 300m;
decimal demandRate = 700m;
decimal holdingCost = 0.006538m;

decimal eoq = OrderQuantityService.EconomicOrderQuantity(setupCost, demandRate, holdingCost);

Console.WriteLine($"EOQ: {eoq}");
Process analysis example
using DeepSigma.SupplyChainManagement.Utilities;

decimal averageInventory = ProcessAnalysisUtilities.AverageInventory(
    average_flow_rate: 12m,
    average_flow_time: 4m);

decimal utilization = ProcessAnalysisUtilities.ComputeUtilization(
    flow_rate: 8m,
    process_capacity: 10m);

Console.WriteLine($"Average Inventory: {averageInventory}");
Console.WriteLine($"Utilization: {utilization}");
Quality control example
using DeepSigma.SupplyChainManagement.Utilities;

decimal cp = QualityControlUtilities.ComputeProcessCapabilityIndex(
    upper_specification_limit: 10m,
    lower_specification_limit: 2m,
    process_standard_deviation: 1m);

decimal ucl = QualityControlUtilities.UpperControlLimit(
    process_mean: 50m,
    process_standard_deviation: 4m);

Console.WriteLine($"Cp: {cp}");
Console.WriteLine($"Upper Control Limit: {ucl}");
Supply chain coordination example
using DeepSigma.SupplyChainManagement.SupplyChainCoordination;

decimal buyBackPrice =
    SupplyChainCoordinationUtilities.BuyBackPriceToMaximizeSupplyChainTotalProfit(
        price: 120m,
        cost: 40m,
        salvage_value: 20m,
        whole_sale_price: 70m,
        shipping_cost: 5m);

Console.WriteLine($"Buy-back price: {buyBackPrice}");
Tested components

The current automated tests validate:

Newsvendor
OrderQuantityService

This gives a solid starting point for the two most prominent inventory-focused components, but additional coverage would strengthen confidence in the rest of the library.

Design goals
Keep formulas easy to consume from application code
Provide supply chain and operations-management helpers with minimal setup
Support teaching, prototyping, and operational analytics scenarios
Favor plain C# models and static utilities over heavy framework abstractions
Contributing

Contributions are welcome. Useful contributions include:

More unit tests
API cleanup and naming consistency
Additional supply-chain formulas
Documentation improvements
Examples and tutorials

To contribute:

Fork the repository
Create a feature branch
Add or update tests
Open a pull request
License

MIT License
