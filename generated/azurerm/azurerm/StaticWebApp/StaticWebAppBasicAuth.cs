using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StaticWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.staticWebApp.StaticWebAppBasicAuth")]
    public class StaticWebAppBasicAuth : azurerm.StaticWebApp.IStaticWebAppBasicAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#environments StaticWebApp#environments}.</summary>
        [JsiiProperty(name: "environments", typeJson: "{\"primitive\":\"string\"}")]
        public string Environments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#password StaticWebApp#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }
    }
}
