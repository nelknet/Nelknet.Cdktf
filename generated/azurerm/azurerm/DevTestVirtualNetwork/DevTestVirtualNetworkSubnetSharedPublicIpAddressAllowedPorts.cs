using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts")]
    public class DevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts : azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddressAllowedPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#backend_port DevTestVirtualNetwork#backend_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackendPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#transport_protocol DevTestVirtualNetwork#transport_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportProtocol
        {
            get;
            set;
        }
    }
}
