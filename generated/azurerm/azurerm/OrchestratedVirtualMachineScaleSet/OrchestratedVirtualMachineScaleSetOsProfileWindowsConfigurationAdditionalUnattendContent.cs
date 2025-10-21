using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent")]
    public class OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#content OrchestratedVirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#setting OrchestratedVirtualMachineScaleSet#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        public string Setting
        {
            get;
            set;
        }
    }
}
