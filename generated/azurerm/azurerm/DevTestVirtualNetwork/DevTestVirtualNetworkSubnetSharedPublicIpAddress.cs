using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress")]
    public class DevTestVirtualNetworkSubnetSharedPublicIpAddress : azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress
    {
        private object? _allowedPorts;

        /// <summary>allowed_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#allowed_ports DevTestVirtualNetwork#allowed_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedPorts
        {
            get => _allowedPorts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedPorts = value;
            }
        }
    }
}
