using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageSync
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageSyncTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageSync.DataAzurermStorageSyncTimeouts")]
    public interface IDataAzurermStorageSyncTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#read DataAzurermStorageSync#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageSyncTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageSync.DataAzurermStorageSyncTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageSync.IDataAzurermStorageSyncTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_sync#read DataAzurermStorageSync#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
