using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageContainer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageContainerTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageContainer.DataAzurermStorageContainerTimeouts")]
    public interface IDataAzurermStorageContainerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#read DataAzurermStorageContainer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageContainerTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageContainer.DataAzurermStorageContainerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageContainer.IDataAzurermStorageContainerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_container#read DataAzurermStorageContainer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
