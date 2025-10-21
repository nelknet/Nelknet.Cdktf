using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetPacketCapture
{
    [JsiiByValue(fqn: "azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureMachineScope")]
    public class VirtualMachineScaleSetPacketCaptureMachineScope : azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureMachineScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#exclude_instance_ids VirtualMachineScaleSetPacketCapture#exclude_instance_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludeInstanceIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#include_instance_ids VirtualMachineScaleSetPacketCapture#include_instance_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeInstanceIds
        {
            get;
            set;
        }
    }
}
