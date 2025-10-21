using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppTimeouts")]
    public class DataAzurermWindowsWebAppTimeouts : azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/windows_web_app#read DataAzurermWindowsWebApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
