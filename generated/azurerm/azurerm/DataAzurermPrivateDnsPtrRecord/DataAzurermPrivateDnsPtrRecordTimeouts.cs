using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsPtrRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordTimeouts")]
    public class DataAzurermPrivateDnsPtrRecordTimeouts : azurerm.DataAzurermPrivateDnsPtrRecord.IDataAzurermPrivateDnsPtrRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#read DataAzurermPrivateDnsPtrRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
