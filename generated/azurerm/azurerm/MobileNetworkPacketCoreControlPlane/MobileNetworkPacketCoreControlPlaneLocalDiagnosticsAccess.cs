using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkPacketCoreControlPlane
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkPacketCoreControlPlane.MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess")]
    public class MobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess : azurerm.MobileNetworkPacketCoreControlPlane.IMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#authentication_type MobileNetworkPacketCoreControlPlane#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_packet_core_control_plane#https_server_certificate_url MobileNetworkPacketCoreControlPlane#https_server_certificate_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsServerCertificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsServerCertificateUrl
        {
            get;
            set;
        }
    }
}
