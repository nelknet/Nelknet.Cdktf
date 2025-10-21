using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DedicatedHardwareSecurityModule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleNetworkProfile")]
    public class DedicatedHardwareSecurityModuleNetworkProfile : azurerm.DedicatedHardwareSecurityModule.IDedicatedHardwareSecurityModuleNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#network_interface_private_ip_addresses DedicatedHardwareSecurityModule#network_interface_private_ip_addresses}.</summary>
        [JsiiProperty(name: "networkInterfacePrivateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NetworkInterfacePrivateIpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#subnet_id DedicatedHardwareSecurityModule#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
