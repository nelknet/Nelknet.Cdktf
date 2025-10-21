using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsMxRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dnsMxRecord.DnsMxRecordRecord")]
    public class DnsMxRecordRecord : azurerm.DnsMxRecord.IDnsMxRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#exchange DnsMxRecord#exchange}.</summary>
        [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
        public string Exchange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#preference DnsMxRecord#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        public string Preference
        {
            get;
            set;
        }
    }
}
