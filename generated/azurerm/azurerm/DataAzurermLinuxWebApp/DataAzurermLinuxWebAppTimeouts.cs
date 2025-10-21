using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermLinuxWebApp.DataAzurermLinuxWebAppTimeouts")]
    public class DataAzurermLinuxWebAppTimeouts : azurerm.DataAzurermLinuxWebApp.IDataAzurermLinuxWebAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/linux_web_app#read DataAzurermLinuxWebApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
