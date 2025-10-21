using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLocation
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLocation.DataAzurermLocationTimeouts")]
    public class DataAzurermLocationTimeouts : azurerm.DataAzurermLocation.IDataAzurermLocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/location#read DataAzurermLocation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
