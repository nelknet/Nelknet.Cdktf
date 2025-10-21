using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SubscriptionCostManagementExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.subscriptionCostManagementExport.SubscriptionCostManagementExportExportDataOptions")]
    public class SubscriptionCostManagementExportExportDataOptions : azurerm.SubscriptionCostManagementExport.ISubscriptionCostManagementExportExportDataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#time_frame SubscriptionCostManagementExport#time_frame}.</summary>
        [JsiiProperty(name: "timeFrame", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeFrame
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_cost_management_export#type SubscriptionCostManagementExport#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
