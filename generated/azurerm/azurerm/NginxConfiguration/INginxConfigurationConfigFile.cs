using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxConfiguration
{
    [JsiiInterface(nativeType: typeof(INginxConfigurationConfigFile), fullyQualifiedName: "azurerm.nginxConfiguration.NginxConfigurationConfigFile")]
    public interface INginxConfigurationConfigFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#content NginxConfiguration#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#virtual_path NginxConfiguration#virtual_path}.</summary>
        [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INginxConfigurationConfigFile), fullyQualifiedName: "azurerm.nginxConfiguration.NginxConfigurationConfigFile")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxConfiguration.INginxConfigurationConfigFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#content NginxConfiguration#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_configuration#virtual_path NginxConfiguration#virtual_path}.</summary>
            [JsiiProperty(name: "virtualPath", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
