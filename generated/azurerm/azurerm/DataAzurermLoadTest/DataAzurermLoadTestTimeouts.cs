using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLoadTest
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLoadTest.DataAzurermLoadTestTimeouts")]
    public class DataAzurermLoadTestTimeouts : azurerm.DataAzurermLoadTest.IDataAzurermLoadTestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#read DataAzurermLoadTest#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
