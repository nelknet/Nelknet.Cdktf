using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsZone
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsZone.DataAzurermDnsZoneTimeouts")]
    public class DataAzurermDnsZoneTimeouts : azurerm.DataAzurermDnsZone.IDataAzurermDnsZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#read DataAzurermDnsZone#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
