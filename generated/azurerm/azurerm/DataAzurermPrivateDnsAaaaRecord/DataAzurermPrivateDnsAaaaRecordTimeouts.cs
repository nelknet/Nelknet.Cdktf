using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsAaaaRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsAaaaRecord.DataAzurermPrivateDnsAaaaRecordTimeouts")]
    public class DataAzurermPrivateDnsAaaaRecordTimeouts : azurerm.DataAzurermPrivateDnsAaaaRecord.IDataAzurermPrivateDnsAaaaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_aaaa_record#read DataAzurermPrivateDnsAaaaRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
