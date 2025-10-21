using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageTableEntity
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageTableEntityTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageTableEntity.DataAzurermStorageTableEntityTimeouts")]
    public interface IDataAzurermStorageTableEntityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#read DataAzurermStorageTableEntity#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageTableEntityTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageTableEntity.DataAzurermStorageTableEntityTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageTableEntity.IDataAzurermStorageTableEntityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entity#read DataAzurermStorageTableEntity#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
