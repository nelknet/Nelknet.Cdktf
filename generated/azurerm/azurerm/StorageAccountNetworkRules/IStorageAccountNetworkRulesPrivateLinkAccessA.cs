using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccountNetworkRules
{
    [JsiiInterface(nativeType: typeof(IStorageAccountNetworkRulesPrivateLinkAccessA), fullyQualifiedName: "azurerm.storageAccountNetworkRules.StorageAccountNetworkRulesPrivateLinkAccessA")]
    public interface IStorageAccountNetworkRulesPrivateLinkAccessA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_resource_id StorageAccountNetworkRulesA#endpoint_resource_id}.</summary>
        [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_tenant_id StorageAccountNetworkRulesA#endpoint_tenant_id}.</summary>
        [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointTenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountNetworkRulesPrivateLinkAccessA), fullyQualifiedName: "azurerm.storageAccountNetworkRules.StorageAccountNetworkRulesPrivateLinkAccessA")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccountNetworkRules.IStorageAccountNetworkRulesPrivateLinkAccessA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_resource_id StorageAccountNetworkRulesA#endpoint_resource_id}.</summary>
            [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account_network_rules#endpoint_tenant_id StorageAccountNetworkRulesA#endpoint_tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointTenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
