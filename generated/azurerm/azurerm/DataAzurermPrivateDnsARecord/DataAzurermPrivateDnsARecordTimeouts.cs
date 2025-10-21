using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsARecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsARecord.DataAzurermPrivateDnsARecordTimeouts")]
    public class DataAzurermPrivateDnsARecordTimeouts : azurerm.DataAzurermPrivateDnsARecord.IDataAzurermPrivateDnsARecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_a_record#read DataAzurermPrivateDnsARecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
