using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorDiagnosticCategories
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMonitorDiagnosticCategories.DataAzurermMonitorDiagnosticCategoriesTimeouts")]
    public class DataAzurermMonitorDiagnosticCategoriesTimeouts : azurerm.DataAzurermMonitorDiagnosticCategories.IDataAzurermMonitorDiagnosticCategoriesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_diagnostic_categories#read DataAzurermMonitorDiagnosticCategories#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
