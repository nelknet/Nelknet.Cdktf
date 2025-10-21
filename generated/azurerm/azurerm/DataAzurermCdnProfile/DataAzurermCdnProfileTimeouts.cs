using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnProfile
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCdnProfile.DataAzurermCdnProfileTimeouts")]
    public class DataAzurermCdnProfileTimeouts : azurerm.DataAzurermCdnProfile.IDataAzurermCdnProfileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#read DataAzurermCdnProfile#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
