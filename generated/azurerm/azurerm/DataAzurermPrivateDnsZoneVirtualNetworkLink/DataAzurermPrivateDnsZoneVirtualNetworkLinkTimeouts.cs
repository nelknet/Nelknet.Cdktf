using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsZoneVirtualNetworkLink.DataAzurermPrivateDnsZoneVirtualNetworkLinkTimeouts")]
    public class DataAzurermPrivateDnsZoneVirtualNetworkLinkTimeouts : azurerm.DataAzurermPrivateDnsZoneVirtualNetworkLink.IDataAzurermPrivateDnsZoneVirtualNetworkLinkTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_zone_virtual_network_link#read DataAzurermPrivateDnsZoneVirtualNetworkLink#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
