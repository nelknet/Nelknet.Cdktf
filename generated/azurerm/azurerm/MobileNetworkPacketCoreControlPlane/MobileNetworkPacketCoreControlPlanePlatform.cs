using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkPacketCoreControlPlane
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlanePlatform")]
    public class MobileNetworkPacketCoreControlPlanePlatform : azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlanePlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#type MobileNetworkPacketCoreControlPlane#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#arc_kubernetes_cluster_id MobileNetworkPacketCoreControlPlane#arc_kubernetes_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arcKubernetesClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ArcKubernetesClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#custom_location_id MobileNetworkPacketCoreControlPlane#custom_location_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customLocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomLocationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#edge_device_id MobileNetworkPacketCoreControlPlane#edge_device_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeDeviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeDeviceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#stack_hci_cluster_id MobileNetworkPacketCoreControlPlane#stack_hci_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stackHciClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StackHciClusterId
        {
            get;
            set;
        }
    }
}
