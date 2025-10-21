using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestVirtualNetwork
{
    [JsiiByValue(fqn: "azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnet")]
    public class DevTestVirtualNetworkSubnet : azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnet
    {
        /// <summary>shared_public_ip_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#shared_public_ip_address DevTestVirtualNetwork#shared_public_ip_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharedPublicIpAddress", typeJson: "{\"fqn\":\"azurerm.devTestVirtualNetwork.DevTestVirtualNetworkSubnetSharedPublicIpAddress\"}", isOptional: true)]
        public azurerm.DevTestVirtualNetwork.IDevTestVirtualNetworkSubnetSharedPublicIpAddress? SharedPublicIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_in_virtual_machine_creation DevTestVirtualNetwork#use_in_virtual_machine_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useInVirtualMachineCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UseInVirtualMachineCreation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_virtual_network#use_public_ip_address DevTestVirtualNetwork#use_public_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usePublicIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsePublicIpAddress
        {
            get;
            set;
        }
    }
}
