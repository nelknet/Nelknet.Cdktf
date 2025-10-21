using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogAnalyticsWorkspace
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLogAnalyticsWorkspace.DataAzurermLogAnalyticsWorkspaceTimeouts")]
    public class DataAzurermLogAnalyticsWorkspaceTimeouts : azurerm.DataAzurermLogAnalyticsWorkspace.IDataAzurermLogAnalyticsWorkspaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/log_analytics_workspace#read DataAzurermLogAnalyticsWorkspace#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
