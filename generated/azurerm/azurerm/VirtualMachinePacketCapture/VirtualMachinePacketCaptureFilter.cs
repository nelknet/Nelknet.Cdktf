using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachinePacketCapture
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachinePacketCapture.VirtualMachinePacketCaptureFilter")]
    public class VirtualMachinePacketCaptureFilter : azurerm.VirtualMachinePacketCapture.IVirtualMachinePacketCaptureFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#protocol VirtualMachinePacketCapture#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_ip_address VirtualMachinePacketCapture#local_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_port VirtualMachinePacketCapture#local_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localPort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_ip_address VirtualMachinePacketCapture#remote_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_port VirtualMachinePacketCapture#remote_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remotePort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemotePort
        {
            get;
            set;
        }
    }
}
