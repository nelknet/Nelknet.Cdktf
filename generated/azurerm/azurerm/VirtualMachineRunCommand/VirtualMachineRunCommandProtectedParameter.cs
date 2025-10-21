using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandProtectedParameter")]
    public class VirtualMachineRunCommandProtectedParameter : azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandProtectedParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#name VirtualMachineRunCommand#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#value VirtualMachineRunCommand#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
