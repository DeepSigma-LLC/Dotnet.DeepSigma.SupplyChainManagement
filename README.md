\# DeepSigma.SupplyChainManagement



A C#/.NET library for common supply chain, inventory, process analysis, quality control, and variability calculations.



This package is designed for analysts, engineers, and developers who want reusable formulas and lightweight domain models for operational decision-making in manufacturing, logistics, and supply chain workflows.



\## Features



\* \*\*Newsvendor modeling\*\*



&nbsp; \* Critical ratio

&nbsp; \* Optimal order quantity

&nbsp; \* Expected sales, leftover inventory, revenue, cost, and profit

&nbsp; \* In-stock and stockout probabilities

&nbsp; \* Quantity required to hit a target service level

&nbsp; \* Forecast calibration via actual-to-forecast ratio



\* \*\*Inventory management\*\*



&nbsp; \* Recommended batch size

&nbsp; \* Economic order quantity (EOQ)

&nbsp; \* EOQ cost

&nbsp; \* Setup and inventory cost rate calculations

&nbsp; \* Batch-size decisions based on process constraints



\* \*\*Process analysis\*\*



&nbsp; \* Inventory, flow rate, and flow time calculations

&nbsp; \* Capacity and bottleneck-oriented helpers

&nbsp; \* Utilization and implied utilization

&nbsp; \* Labor utilization

&nbsp; \* Little’s Law helpers

&nbsp; \* Capacity calculations with setup time and batch size



\* \*\*Quality control\*\*



&nbsp; \* Process capability index (Cp)

&nbsp; \* Defect probability

&nbsp; \* Control limits

&nbsp; \* Yield calculations

&nbsp; \* Flow-unit requirements to hit a target yield



\* \*\*Variability / queueing-style utilities\*\*



&nbsp; \* Approximate wait time calculations

&nbsp; \* Throughput-loss style helpers

&nbsp; \* Production-model selection support



\* \*\*Supply chain coordination\*\*



&nbsp; \* Buy-back price calculation for coordinating retailer/manufacturer incentives



\## Repository structure



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

```



\## Target framework



This library currently targets:



\* `.NET 10`



\## Getting started



\### Clone the repository



```bash

git clone https://github.com/DeepSigma-LLC/Dotnet.DeepSigma.SupplyChainManagement.git

cd Dotnet.DeepSigma.SupplyChainManagement

```



\### Build



```bash

dotnet build

```



\### Run tests



```bash

dotnet test

```



\## Usage



\### Newsvendor example



```csharp

using DeepSigma.SupplyChainManagement;



var newsvendor = new Newsvendor

{

&nbsp;   Mean = 3192m,

&nbsp;   StandardDeviation = 1181m,

&nbsp;   OverageCost = 20m,

&nbsp;   UnderageCost = 80m,

&nbsp;   SelectedValue = 3500m,

&nbsp;   Price = 120m,

&nbsp;   Cost = 40m,

&nbsp;   SalvageValue = 20m,

&nbsp;   ActualDemand = 3776.265m

};



Console.WriteLine($"Critical Ratio: {newsvendor.CriticalRatio}");

Console.WriteLine($"Optimal Quantity: {newsvendor.OptimalQuantity}");

Console.WriteLine($"Expected Profit: {newsvendor.ExpectedProfit}");

Console.WriteLine($"In-stock Probability: {newsvendor.GetInstockProbability(3500m)}");

```



\### Inventory management example



```csharp

using DeepSigma.SupplyChainManagement.InventoryManagement;



decimal setupCost = 300m;

decimal demandRate = 700m;

decimal holdingCost = 0.006538m;



decimal eoq = OrderQuantityService.EconomicOrderQuantity(setupCost, demandRate, holdingCost);



Console.WriteLine($"EOQ: {eoq}");

```



\### Process analysis example



```csharp

using DeepSigma.SupplyChainManagement.Utilities;



decimal averageInventory = ProcessAnalysisUtilities.AverageInventory(

&nbsp;   average\_flow\_rate: 12m,

&nbsp;   average\_flow\_time: 4m);



decimal utilization = ProcessAnalysisUtilities.ComputeUtilization(

&nbsp;   flow\_rate: 8m,

&nbsp;   process\_capacity: 10m);



Console.WriteLine($"Average Inventory: {averageInventory}");

Console.WriteLine($"Utilization: {utilization}");

```



\### Quality control example



```csharp

using DeepSigma.SupplyChainManagement.Utilities;



decimal cp = QualityControlUtilities.ComputeProcessCapabilityIndex(

&nbsp;   upper\_specification\_limit: 10m,

&nbsp;   lower\_specification\_limit: 2m,

&nbsp;   process\_standard\_deviation: 1m);



decimal ucl = QualityControlUtilities.UpperControlLimit(

&nbsp;   process\_mean: 50m,

&nbsp;   process\_standard\_deviation: 4m);



Console.WriteLine($"Cp: {cp}");

Console.WriteLine($"Upper Control Limit: {ucl}");

```



\### Supply chain coordination example



```csharp

using DeepSigma.SupplyChainManagement.SupplyChainCoordination;



decimal buyBackPrice =

&nbsp;   SupplyChainCoordinationUtilities.BuyBackPriceToMaximizeSupplyChainTotalProfit(

&nbsp;       price: 120m,

&nbsp;       cost: 40m,

&nbsp;       salvage\_value: 20m,

&nbsp;       whole\_sale\_price: 70m,

&nbsp;       shipping\_cost: 5m);



Console.WriteLine($"Buy-back price: {buyBackPrice}");

```



\## Tested components



The current automated tests validate:



\* `Newsvendor`

\* `OrderQuantityService`



This gives a solid starting point for the two most prominent inventory-focused components, but additional coverage would strengthen confidence in the rest of the library.



\## Design goals



\* Keep formulas easy to consume from application code

\* Provide supply chain and operations-management helpers with minimal setup

\* Support teaching, prototyping, and operational analytics scenarios

\* Favor plain C# models and static utilities over heavy framework abstractions



\## License



MIT License

