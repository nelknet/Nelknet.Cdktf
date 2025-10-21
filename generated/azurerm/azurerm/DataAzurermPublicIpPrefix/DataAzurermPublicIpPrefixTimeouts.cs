using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPublicIpPrefix
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixTimeouts")]
    public class DataAzurermPublicIpPrefixTimeouts : azurerm.DataAzurermPublicIpPrefix.IDataAzurermPublicIpPrefixTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#read DataAzurermPublicIpPrefix#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
