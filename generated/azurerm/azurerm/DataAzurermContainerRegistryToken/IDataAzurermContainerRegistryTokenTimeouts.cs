using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerRegistryToken
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerRegistryTokenTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistryToken.DataAzurermContainerRegistryTokenTimeouts")]
    public interface IDataAzurermContainerRegistryTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#read DataAzurermContainerRegistryToken#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerRegistryTokenTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerRegistryToken.DataAzurermContainerRegistryTokenTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerRegistryToken.IDataAzurermContainerRegistryTokenTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#read DataAzurermContainerRegistryToken#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
