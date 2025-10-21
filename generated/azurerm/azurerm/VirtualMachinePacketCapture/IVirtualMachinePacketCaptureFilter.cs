using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachinePacketCapture
{
    [JsiiInterface(nativeType: typeof(IVirtualMachinePacketCaptureFilter), fullyQualifiedName: "azurerm.virtualMachinePacketCapture.VirtualMachinePacketCaptureFilter")]
    public interface IVirtualMachinePacketCaptureFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#protocol VirtualMachinePacketCapture#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_ip_address VirtualMachinePacketCapture#local_ip_address}.</summary>
        [JsiiProperty(name: "localIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_port VirtualMachinePacketCapture#local_port}.</summary>
        [JsiiProperty(name: "localPort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_ip_address VirtualMachinePacketCapture#remote_ip_address}.</summary>
        [JsiiProperty(name: "remoteIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_port VirtualMachinePacketCapture#remote_port}.</summary>
        [JsiiProperty(name: "remotePort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemotePort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachinePacketCaptureFilter), fullyQualifiedName: "azurerm.virtualMachinePacketCapture.VirtualMachinePacketCaptureFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachinePacketCapture.IVirtualMachinePacketCaptureFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#protocol VirtualMachinePacketCapture#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_ip_address VirtualMachinePacketCapture#local_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalIpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#local_port VirtualMachinePacketCapture#local_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localPort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalPort
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_ip_address VirtualMachinePacketCapture#remote_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteIpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#remote_port VirtualMachinePacketCapture#remote_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remotePort", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemotePort
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
