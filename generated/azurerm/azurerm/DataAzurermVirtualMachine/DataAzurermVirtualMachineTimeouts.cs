using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.dataAzurermVirtualMachine.DataAzurermVirtualMachineTimeouts")]
    public class DataAzurermVirtualMachineTimeouts : azurerm.DataAzurermVirtualMachine.IDataAzurermVirtualMachineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#read DataAzurermVirtualMachine#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
