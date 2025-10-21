using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsTxtRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dnsTxtRecord.DnsTxtRecordRecord")]
    public class DnsTxtRecordRecord : azurerm.DnsTxtRecord.IDnsTxtRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_txt_record#value DnsTxtRecord#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
