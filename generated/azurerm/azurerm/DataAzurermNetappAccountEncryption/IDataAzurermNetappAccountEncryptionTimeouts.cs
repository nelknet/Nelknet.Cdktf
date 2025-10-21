using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappAccountEncryption
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappAccountEncryptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts")]
    public interface IDataAzurermNetappAccountEncryptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#read DataAzurermNetappAccountEncryption#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappAccountEncryptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappAccountEncryption.DataAzurermNetappAccountEncryptionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappAccountEncryption.IDataAzurermNetappAccountEncryptionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account_encryption#read DataAzurermNetappAccountEncryption#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
