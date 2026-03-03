
namespace DeepSigma.SupplyChainManagement.QualityControl.Enums;

/// <summary>
/// Defect Management Method is an enumeration that defines the different approaches to managing defects in the production process.
/// </summary>
public enum DefectManagementMethod
{
    /// <summary>
    /// Rework refers to the process of correcting a defect in a product or component by making necessary adjustments or repairs to bring it back to the desired quality standards.
    /// </summary>
    Rework,
    /// <summary>
    /// Scrap refers to the process of discarding a defective product or component that cannot be repaired or brought back to the desired quality standards.
    /// This is typically done when the cost of reworking the product exceeds the cost of scrapping it, or when the defect is severe enough that it cannot be effectively repaired.
    /// This idea can also be use to indicate project abandonment in the case where a project is deemed to be no longer viable or worth pursuing due to significant defects or issues that cannot be effectively addressed.
    /// For example, in the pharmaceutical industry, if a drug candidate fails to meet safety or efficacy standards during clinical trials, the project may be scrapped to avoid further investment in a product that is unlikely to succeed in the market.
    /// </summary>
    Scrap,

}
