using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiByValue(fqn: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage : azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#account_name WorkloadsSapThreeTierVirtualInstance#account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#private_endpoint_name WorkloadsSapThreeTierVirtualInstance#private_endpoint_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointName
        {
            get;
            set;
        }
    }
}
