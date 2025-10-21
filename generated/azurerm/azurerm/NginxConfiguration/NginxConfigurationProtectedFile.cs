using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.nginxConfiguration.NginxConfigurationProtectedFile")]
    public class NginxConfigurationProtectedFile : azurerm.NginxConfiguration.INginxConfigurationProtectedFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#content NginxConfiguration#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#virtual_path NginxConfiguration#virtual_path}.</summary>
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}")]
        public string VirtualPath
        {
            get;
            set;
        }
    }
}
