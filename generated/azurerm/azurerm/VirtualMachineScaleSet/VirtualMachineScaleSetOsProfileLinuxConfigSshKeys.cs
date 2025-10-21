using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigSshKeys")]
    public class VirtualMachineScaleSetOsProfileLinuxConfigSshKeys : azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfigSshKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#path VirtualMachineScaleSet#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#key_data VirtualMachineScaleSet#key_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyData
        {
            get;
            set;
        }
    }
}
