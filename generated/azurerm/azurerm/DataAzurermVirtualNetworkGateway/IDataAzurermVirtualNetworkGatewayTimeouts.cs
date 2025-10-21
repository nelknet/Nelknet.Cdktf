using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualNetworkGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayTimeouts")]
    public interface IDataAzurermVirtualNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#read DataAzurermVirtualNetworkGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualNetworkGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualNetworkGateway.DataAzurermVirtualNetworkGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualNetworkGateway.IDataAzurermVirtualNetworkGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_network_gateway#read DataAzurermVirtualNetworkGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
