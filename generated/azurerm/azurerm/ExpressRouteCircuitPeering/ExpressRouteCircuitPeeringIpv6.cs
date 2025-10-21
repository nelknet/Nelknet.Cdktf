using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteCircuitPeering
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6")]
    public class ExpressRouteCircuitPeeringIpv6 : azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#primary_peer_address_prefix ExpressRouteCircuitPeering#primary_peer_address_prefix}.</summary>
        [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string PrimaryPeerAddressPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#secondary_peer_address_prefix ExpressRouteCircuitPeering#secondary_peer_address_prefix}.</summary>
        [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string SecondaryPeerAddressPrefix
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#enabled ExpressRouteCircuitPeering#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>microsoft_peering block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#microsoft_peering ExpressRouteCircuitPeering#microsoft_peering}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftPeering", typeJson: "{\"fqn\":\"azurerm.expressRouteCircuitPeering.ExpressRouteCircuitPeeringIpv6MicrosoftPeering\"}", isOptional: true)]
        public azurerm.ExpressRouteCircuitPeering.IExpressRouteCircuitPeeringIpv6MicrosoftPeering? MicrosoftPeering
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit_peering#route_filter_id ExpressRouteCircuitPeering#route_filter_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeFilterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteFilterId
        {
            get;
            set;
        }
    }
}
