namespace DeepSigma.SupplyChainManagement.ProcessAnalysis.Enums;

/// <summary>
/// Machine setup task categorize to two primary classifications of machine setup tasks: internal and external.
/// </summary>
public enum MachineSetupTask
{
    /// <summary>
    /// Internal machine setup tasks are those that can only be performed when the machine is stopped and not producing any output. 
    /// These tasks typically involve activities such as changing tools, adjusting machine settings, or performing maintenance that requires the machine to be idle.
    /// </summary>
    Internal,
    /// <summary>
    /// External machine setup tasks are those that can be performed while the machine is still running and producing output.
    /// </summary>
    External,
}
