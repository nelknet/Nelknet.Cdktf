using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress")]
    public class VpnGatewayBgpSettingsInstance1BgpPeeringAddress : azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_gateway#custom_ips VpnGateway#custom_ips}.</summary>
        [JsiiProperty(name: "customIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CustomIps
        {
            get;
            set;
        }
    }
}
