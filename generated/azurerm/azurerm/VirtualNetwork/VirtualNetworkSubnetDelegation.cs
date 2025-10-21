using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.virtualNetwork.VirtualNetworkSubnetDelegation")]
    public class VirtualNetworkSubnetDelegation : azurerm.VirtualNetwork.IVirtualNetworkSubnetDelegation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#name VirtualNetwork#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _serviceDelegation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_network#service_delegation VirtualNetwork#service_delegation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceDelegation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualNetwork.VirtualNetworkSubnetDelegationServiceDelegation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServiceDelegation
        {
            get => _serviceDelegation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.VirtualNetwork.IVirtualNetworkSubnetDelegationServiceDelegation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualNetwork.IVirtualNetworkSubnetDelegationServiceDelegation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceDelegation = value;
            }
        }
    }
}
