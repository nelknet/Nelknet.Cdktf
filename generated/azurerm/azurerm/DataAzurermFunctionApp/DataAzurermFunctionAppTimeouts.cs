using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermFunctionApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermFunctionApp.DataAzurermFunctionAppTimeouts")]
    public class DataAzurermFunctionAppTimeouts : azurerm.DataAzurermFunctionApp.IDataAzurermFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/function_app#read DataAzurermFunctionApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
