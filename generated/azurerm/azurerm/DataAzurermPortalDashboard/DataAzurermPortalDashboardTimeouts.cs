using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPortalDashboard
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPortalDashboard.DataAzurermPortalDashboardTimeouts")]
    public class DataAzurermPortalDashboardTimeouts : azurerm.DataAzurermPortalDashboard.IDataAzurermPortalDashboardTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/portal_dashboard#read DataAzurermPortalDashboard#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
