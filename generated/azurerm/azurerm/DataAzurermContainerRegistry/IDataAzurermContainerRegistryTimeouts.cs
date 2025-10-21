using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistry
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerRegistryTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistry.DataAzurermContainerRegistryTimeouts")]
    public interface IDataAzurermContainerRegistryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#read DataAzurermContainerRegistry#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerRegistryTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistry.DataAzurermContainerRegistryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerRegistry.IDataAzurermContainerRegistryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#read DataAzurermContainerRegistry#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
