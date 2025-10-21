using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPublicIps
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPublicIps.DataAzurermPublicIpsTimeouts")]
    public class DataAzurermPublicIpsTimeouts : azurerm.DataAzurermPublicIps.IDataAzurermPublicIpsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#read DataAzurermPublicIps#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
