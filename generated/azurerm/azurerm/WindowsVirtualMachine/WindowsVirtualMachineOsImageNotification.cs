using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.windowsVirtualMachine.WindowsVirtualMachineOsImageNotification")]
    public class WindowsVirtualMachineOsImageNotification : azurerm.WindowsVirtualMachine.IWindowsVirtualMachineOsImageNotification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#timeout WindowsVirtualMachine#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timeout
        {
            get;
            set;
        }
    }
}
