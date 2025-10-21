using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStaticWebApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermStaticWebApp.DataAzurermStaticWebAppTimeouts")]
    public class DataAzurermStaticWebAppTimeouts : azurerm.DataAzurermStaticWebApp.IDataAzurermStaticWebAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/static_web_app#read DataAzurermStaticWebApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
