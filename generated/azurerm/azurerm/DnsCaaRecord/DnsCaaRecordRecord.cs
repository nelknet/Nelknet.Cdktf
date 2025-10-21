using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsCaaRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dnsCaaRecord.DnsCaaRecordRecord")]
    public class DnsCaaRecordRecord : azurerm.DnsCaaRecord.IDnsCaaRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#flags DnsCaaRecord#flags}.</summary>
        [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
        public double Flags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#tag DnsCaaRecord#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public string Tag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_caa_record#value DnsCaaRecord#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
