using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsSrvRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordTimeouts")]
    public class DataAzurermDnsSrvRecordTimeouts : azurerm.DataAzurermDnsSrvRecord.IDataAzurermDnsSrvRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#read DataAzurermDnsSrvRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
