using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageAccount.StorageAccountNetworkRulesPrivateLinkAccess")]
    public class StorageAccountNetworkRulesPrivateLinkAccess : azurerm.StorageAccount.IStorageAccountNetworkRulesPrivateLinkAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_resource_id StorageAccount#endpoint_resource_id}.</summary>
        [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_tenant_id StorageAccount#endpoint_tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointTenantId
        {
            get;
            set;
        }
    }
}
