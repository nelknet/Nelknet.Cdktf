using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsVirtualMachine.WindowsVirtualMachineOsDiskDiffDiskSettings")]
    public class WindowsVirtualMachineOsDiskDiffDiskSettings : azurerm.WindowsVirtualMachine.IWindowsVirtualMachineOsDiskDiffDiskSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#option WindowsVirtualMachine#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}")]
        public string Option
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#placement WindowsVirtualMachine#placement}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Placement
        {
            get;
            set;
        }
    }
}
