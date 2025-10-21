using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsCaaRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordTimeouts")]
    public class DataAzurermDnsCaaRecordTimeouts : azurerm.DataAzurermDnsCaaRecord.IDataAzurermDnsCaaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#read DataAzurermDnsCaaRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
