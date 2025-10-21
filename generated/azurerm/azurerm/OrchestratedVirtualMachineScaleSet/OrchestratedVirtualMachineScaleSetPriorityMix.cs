using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetPriorityMix")]
    public class OrchestratedVirtualMachineScaleSetPriorityMix : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetPriorityMix
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#base_regular_count OrchestratedVirtualMachineScaleSet#base_regular_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseRegularCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BaseRegularCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#regular_percentage_above_base OrchestratedVirtualMachineScaleSet#regular_percentage_above_base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regularPercentageAboveBase", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RegularPercentageAboveBase
        {
            get;
            set;
        }
    }
}
