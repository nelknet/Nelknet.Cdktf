using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPublicIp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPublicIp.DataAzurermPublicIpTimeouts")]
    public class DataAzurermPublicIpTimeouts : azurerm.DataAzurermPublicIp.IDataAzurermPublicIpTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#read DataAzurermPublicIp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
