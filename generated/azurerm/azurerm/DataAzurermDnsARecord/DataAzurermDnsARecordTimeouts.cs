using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsARecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsARecord.DataAzurermDnsARecordTimeouts")]
    public class DataAzurermDnsARecordTimeouts : azurerm.DataAzurermDnsARecord.IDataAzurermDnsARecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#read DataAzurermDnsARecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
