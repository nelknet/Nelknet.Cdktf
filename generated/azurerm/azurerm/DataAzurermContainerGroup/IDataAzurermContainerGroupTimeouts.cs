using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermContainerGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerGroup.DataAzurermContainerGroupTimeouts")]
    public interface IDataAzurermContainerGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#read DataAzurermContainerGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermContainerGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermContainerGroup.DataAzurermContainerGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermContainerGroup.IDataAzurermContainerGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_group#read DataAzurermContainerGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
