using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.linuxVirtualMachine.LinuxVirtualMachineOsImageNotification")]
    public class LinuxVirtualMachineOsImageNotification : azurerm.LinuxVirtualMachine.ILinuxVirtualMachineOsImageNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#timeout LinuxVirtualMachine#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timeout
        {
            get;
            set;
        }
    }
}
