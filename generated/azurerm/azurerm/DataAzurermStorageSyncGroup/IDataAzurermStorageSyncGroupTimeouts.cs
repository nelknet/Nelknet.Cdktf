using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageSyncGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageSyncGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageSyncGroup.DataAzurermStorageSyncGroupTimeouts")]
    public interface IDataAzurermStorageSyncGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#read DataAzurermStorageSyncGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageSyncGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageSyncGroup.DataAzurermStorageSyncGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageSyncGroup.IDataAzurermStorageSyncGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync_group#read DataAzurermStorageSyncGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
