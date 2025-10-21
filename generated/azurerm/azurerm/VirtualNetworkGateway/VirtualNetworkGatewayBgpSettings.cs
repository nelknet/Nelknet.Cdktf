using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiByValue(fqn: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings")]
    public class VirtualNetworkGatewayBgpSettings : azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#asn VirtualNetworkGateway#asn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Asn
        {
            get;
            set;
        }

        private object? _peeringAddresses;

        /// <summary>peering_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peering_addresses VirtualNetworkGateway#peering_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "peeringAddresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsPeeringAddresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PeeringAddresses
        {
            get => _peeringAddresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettingsPeeringAddresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _peeringAddresses = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network_gateway#peer_weight VirtualNetworkGateway#peer_weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeerWeight
        {
            get;
            set;
        }
    }
}
