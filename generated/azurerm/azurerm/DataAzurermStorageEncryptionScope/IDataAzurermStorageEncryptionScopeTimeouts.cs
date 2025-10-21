using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageEncryptionScope
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageEncryptionScopeTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeTimeouts")]
    public interface IDataAzurermStorageEncryptionScopeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#read DataAzurermStorageEncryptionScope#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageEncryptionScopeTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageEncryptionScope.DataAzurermStorageEncryptionScopeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageEncryptionScope.IDataAzurermStorageEncryptionScopeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_encryption_scope#read DataAzurermStorageEncryptionScope#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
