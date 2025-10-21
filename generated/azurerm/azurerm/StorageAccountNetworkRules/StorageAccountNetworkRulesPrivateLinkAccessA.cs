using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountNetworkRules
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccountNetworkRules.StorageAccountNetworkRulesPrivateLinkAccessA")]
    public class StorageAccountNetworkRulesPrivateLinkAccessA : azurerm.StorageAccountNetworkRules.IStorageAccountNetworkRulesPrivateLinkAccessA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_resource_id StorageAccountNetworkRulesA#endpoint_resource_id}.</summary>
        [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_tenant_id StorageAccountNetworkRulesA#endpoint_tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointTenantId
        {
            get;
            set;
        }
    }
}
