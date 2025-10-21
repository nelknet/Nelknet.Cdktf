using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetwork
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetwork.DataAzurermVirtualNetworkTimeouts")]
    public interface IDataAzurermVirtualNetworkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#read DataAzurermVirtualNetwork#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualNetworkTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetwork.DataAzurermVirtualNetworkTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualNetwork.IDataAzurermVirtualNetworkTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network#read DataAzurermVirtualNetwork#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
