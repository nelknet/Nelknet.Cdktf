using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateDnsMxRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.privateDnsMxRecord.PrivateDnsMxRecordRecord")]
    public class PrivateDnsMxRecordRecord : azurerm.PrivateDnsMxRecord.IPrivateDnsMxRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#exchange PrivateDnsMxRecord#exchange}.</summary>
        [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
        public string Exchange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#preference PrivateDnsMxRecord#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}")]
        public double Preference
        {
            get;
            set;
        }
    }
}
