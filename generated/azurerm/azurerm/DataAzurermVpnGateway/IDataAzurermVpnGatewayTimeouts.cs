using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVpnGateway
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVpnGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayTimeouts")]
    public interface IDataAzurermVpnGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#read DataAzurermVpnGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVpnGatewayTimeouts), fullyQualifiedName: "azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVpnGateway.IDataAzurermVpnGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/vpn_gateway#read DataAzurermVpnGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
