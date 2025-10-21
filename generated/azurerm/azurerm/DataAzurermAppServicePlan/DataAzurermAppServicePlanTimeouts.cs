using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServicePlan
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAppServicePlan.DataAzurermAppServicePlanTimeouts")]
    public class DataAzurermAppServicePlanTimeouts : azurerm.DataAzurermAppServicePlan.IDataAzurermAppServicePlanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_plan#read DataAzurermAppServicePlan#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
