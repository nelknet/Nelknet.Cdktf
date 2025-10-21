using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageManagementPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyTimeouts")]
    public interface IDataAzurermStorageManagementPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#read DataAzurermStorageManagementPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageManagementPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageManagementPolicy.DataAzurermStorageManagementPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageManagementPolicy.IDataAzurermStorageManagementPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_management_policy#read DataAzurermStorageManagementPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
