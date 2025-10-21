using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkPacketCapture
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkPacketCapture.NetworkPacketCaptureFilter")]
    public class NetworkPacketCaptureFilter : azurerm.NetworkPacketCapture.INetworkPacketCaptureFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#protocol NetworkPacketCapture#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#local_ip_address NetworkPacketCapture#local_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#local_port NetworkPacketCapture#local_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localPort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#remote_ip_address NetworkPacketCapture#remote_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remoteIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemoteIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#remote_port NetworkPacketCapture#remote_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "remotePort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RemotePort
        {
            get;
            set;
        }
    }
}
