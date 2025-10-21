using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DedicatedHardwareSecurityModule
{
    [JsiiInterface(nativeType: typeof(IDedicatedHardwareSecurityModuleNetworkProfile), fullyQualifiedName: "azurerm.dedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleNetworkProfile")]
    public interface IDedicatedHardwareSecurityModuleNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#network_interface_private_ip_addresses DedicatedHardwareSecurityModule#network_interface_private_ip_addresses}.</summary>
        [JsiiProperty(name: "networkInterfacePrivateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NetworkInterfacePrivateIpAddresses
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#subnet_id DedicatedHardwareSecurityModule#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDedicatedHardwareSecurityModuleNetworkProfile), fullyQualifiedName: "azurerm.dedicatedHardwareSecurityModule.DedicatedHardwareSecurityModuleNetworkProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.DedicatedHardwareSecurityModule.IDedicatedHardwareSecurityModuleNetworkProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#network_interface_private_ip_addresses DedicatedHardwareSecurityModule#network_interface_private_ip_addresses}.</summary>
            [JsiiProperty(name: "networkInterfacePrivateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NetworkInterfacePrivateIpAddresses
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_hardware_security_module#subnet_id DedicatedHardwareSecurityModule#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
