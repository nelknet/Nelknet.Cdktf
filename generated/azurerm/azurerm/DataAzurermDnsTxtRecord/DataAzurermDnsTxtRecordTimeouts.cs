using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsTxtRecord
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordTimeouts")]
    public class DataAzurermDnsTxtRecordTimeouts : azurerm.DataAzurermDnsTxtRecord.IDataAzurermDnsTxtRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#read DataAzurermDnsTxtRecord#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
