using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsNsRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsNsRecord.DataAzurermDnsNsRecordTimeouts")]
    public class DataAzurermDnsNsRecordTimeouts : azurerm.DataAzurermDnsNsRecord.IDataAzurermDnsNsRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ns_record#read DataAzurermDnsNsRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
