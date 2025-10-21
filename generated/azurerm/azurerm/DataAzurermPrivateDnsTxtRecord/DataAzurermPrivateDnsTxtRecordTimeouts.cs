using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsTxtRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordTimeouts")]
    public class DataAzurermPrivateDnsTxtRecordTimeouts : azurerm.DataAzurermPrivateDnsTxtRecord.IDataAzurermPrivateDnsTxtRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#read DataAzurermPrivateDnsTxtRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
