using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkPacketCoreControlPlane
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMobileNetworkPacketCoreControlPlaneTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlaneTimeouts")]
    public interface IDataAzurermMobileNetworkPacketCoreControlPlaneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#read DataAzurermMobileNetworkPacketCoreControlPlane#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMobileNetworkPacketCoreControlPlaneTimeouts), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkPacketCoreControlPlane.DataAzurermMobileNetworkPacketCoreControlPlaneTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMobileNetworkPacketCoreControlPlane.IDataAzurermMobileNetworkPacketCoreControlPlaneTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mobile_network_packet_core_control_plane#read DataAzurermMobileNetworkPacketCoreControlPlane#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
