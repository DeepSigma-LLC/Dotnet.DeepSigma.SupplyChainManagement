
using DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

namespace DeepSigma.SupplyChainManagement.Variability;

public static class ProductionModelSelection
{
    public static ProductionModeOfOperation? GetPrefferedProductionMode(bool HighDemandVariability, bool HighInventoryCost, bool QuickAssembly)
    {
        if (QuickAssembly == false)
            return ProductionModeOfOperation.MakeToStock;
        if (HighInventoryCost == true && QuickAssembly == true)
            return ProductionModeOfOperation.MakeToOrder;
        else if (HighInventoryCost == false && HighDemandVariability == true)
            return ProductionModeOfOperation.MakeToStock;
        else
            return null;
    }
}
