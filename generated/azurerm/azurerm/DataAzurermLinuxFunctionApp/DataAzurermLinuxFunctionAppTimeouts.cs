using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxFunctionApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLinuxFunctionApp.DataAzurermLinuxFunctionAppTimeouts")]
    public class DataAzurermLinuxFunctionAppTimeouts : azurerm.DataAzurermLinuxFunctionApp.IDataAzurermLinuxFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_function_app#read DataAzurermLinuxFunctionApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
