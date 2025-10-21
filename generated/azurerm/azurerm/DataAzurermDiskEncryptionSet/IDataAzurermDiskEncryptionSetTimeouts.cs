using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDiskEncryptionSet
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDiskEncryptionSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetTimeouts")]
    public interface IDataAzurermDiskEncryptionSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#read DataAzurermDiskEncryptionSet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDiskEncryptionSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermDiskEncryptionSet.DataAzurermDiskEncryptionSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDiskEncryptionSet.IDataAzurermDiskEncryptionSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_encryption_set#read DataAzurermDiskEncryptionSet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
