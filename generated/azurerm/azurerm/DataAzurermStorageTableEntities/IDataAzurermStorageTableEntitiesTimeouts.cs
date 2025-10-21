using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageTableEntities
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageTableEntitiesTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageTableEntities.DataAzurermStorageTableEntitiesTimeouts")]
    public interface IDataAzurermStorageTableEntitiesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#read DataAzurermStorageTableEntities#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageTableEntitiesTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageTableEntities.DataAzurermStorageTableEntitiesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageTableEntities.IDataAzurermStorageTableEntitiesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_table_entities#read DataAzurermStorageTableEntities#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
