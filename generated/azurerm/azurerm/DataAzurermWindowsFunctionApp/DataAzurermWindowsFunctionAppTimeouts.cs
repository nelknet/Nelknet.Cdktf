using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsFunctionApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermWindowsFunctionApp.DataAzurermWindowsFunctionAppTimeouts")]
    public class DataAzurermWindowsFunctionAppTimeouts : azurerm.DataAzurermWindowsFunctionApp.IDataAzurermWindowsFunctionAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_function_app#read DataAzurermWindowsFunctionApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
