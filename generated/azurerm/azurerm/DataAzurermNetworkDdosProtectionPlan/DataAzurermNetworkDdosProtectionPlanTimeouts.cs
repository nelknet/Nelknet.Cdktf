using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetworkDdosProtectionPlan
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetworkDdosProtectionPlan.DataAzurermNetworkDdosProtectionPlanTimeouts")]
    public class DataAzurermNetworkDdosProtectionPlanTimeouts : azurerm.DataAzurermNetworkDdosProtectionPlan.IDataAzurermNetworkDdosProtectionPlanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_ddos_protection_plan#read DataAzurermNetworkDdosProtectionPlan#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
