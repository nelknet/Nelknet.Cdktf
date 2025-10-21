using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLocalNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLocalNetworkGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayTimeouts")]
    public interface IDataAzurermLocalNetworkGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#read DataAzurermLocalNetworkGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLocalNetworkGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermLocalNetworkGateway.DataAzurermLocalNetworkGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLocalNetworkGateway.IDataAzurermLocalNetworkGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/local_network_gateway#read DataAzurermLocalNetworkGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
