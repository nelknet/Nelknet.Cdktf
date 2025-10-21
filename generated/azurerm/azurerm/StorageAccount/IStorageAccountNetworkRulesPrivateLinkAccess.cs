using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountNetworkRulesPrivateLinkAccess), fullyQualifiedName: "azurerm.storageAccount.StorageAccountNetworkRulesPrivateLinkAccess")]
    public interface IStorageAccountNetworkRulesPrivateLinkAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_resource_id StorageAccount#endpoint_resource_id}.</summary>
        [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_tenant_id StorageAccount#endpoint_tenant_id}.</summary>
        [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointTenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountNetworkRulesPrivateLinkAccess), fullyQualifiedName: "azurerm.storageAccount.StorageAccountNetworkRulesPrivateLinkAccess")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountNetworkRulesPrivateLinkAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_resource_id StorageAccount#endpoint_resource_id}.</summary>
            [JsiiProperty(name: "endpointResourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#endpoint_tenant_id StorageAccount#endpoint_tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointTenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointTenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
