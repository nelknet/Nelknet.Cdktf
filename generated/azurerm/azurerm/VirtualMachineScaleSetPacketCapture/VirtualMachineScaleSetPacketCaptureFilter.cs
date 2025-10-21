using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetPacketCapture
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureFilter")]
    public class VirtualMachineScaleSetPacketCaptureFilter : azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#protocol VirtualMachineScaleSetPacketCapture#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#local_ip_address VirtualMachineScaleSetPacketCapture#local_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#local_port VirtualMachineScaleSetPacketCapture#local_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localPort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#remote_ip_address VirtualMachineScaleSetPacketCapture#remote_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set_packet_capture#remote_port VirtualMachineScaleSetPacketCapture#remote_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remotePort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemotePort
        {
            get;
            set;
        }
    }
}
