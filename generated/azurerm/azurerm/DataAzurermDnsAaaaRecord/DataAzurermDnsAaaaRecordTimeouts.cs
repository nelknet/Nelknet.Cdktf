using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsAaaaRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordTimeouts")]
    public class DataAzurermDnsAaaaRecordTimeouts : azurerm.DataAzurermDnsAaaaRecord.IDataAzurermDnsAaaaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#read DataAzurermDnsAaaaRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
