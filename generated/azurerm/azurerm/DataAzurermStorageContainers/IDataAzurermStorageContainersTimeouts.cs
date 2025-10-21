using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageContainers
{
    [JsiiInterface(nativeType: typeof(IDataAzurermStorageContainersTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageContainers.DataAzurermStorageContainersTimeouts")]
    public interface IDataAzurermStorageContainersTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#read DataAzurermStorageContainers#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermStorageContainersTimeouts), fullyQualifiedName: "azurerm.dataAzurermStorageContainers.DataAzurermStorageContainersTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermStorageContainers.IDataAzurermStorageContainersTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_containers#read DataAzurermStorageContainers#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
