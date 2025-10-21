using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigApplicationStack")]
    public class WindowsWebAppSiteConfigApplicationStack : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigApplicationStack
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#current_stack WindowsWebApp#current_stack}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currentStack", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrentStack
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#docker_image_name WindowsWebApp#docker_image_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerImageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#docker_registry_password WindowsWebApp#docker_registry_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#docker_registry_url WindowsWebApp#docker_registry_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#docker_registry_username WindowsWebApp#docker_registry_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryUsername
        {
            get;
            set;
        }

        /// <summary>The version of DotNetCore to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#dotnet_core_version WindowsWebApp#dotnet_core_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetCoreVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#dotnet_version WindowsWebApp#dotnet_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#java_container WindowsWebApp#java_container}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "javaContainer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaContainer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#java_container_version WindowsWebApp#java_container_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "javaContainerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaContainerVersion
        {
            get;
            set;
        }

        private object? _javaEmbeddedServerEnabled;

        /// <summary>Should the application use the embedded web server for the version of Java in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#java_embedded_server_enabled WindowsWebApp#java_embedded_server_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "javaEmbeddedServerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? JavaEmbeddedServerEnabled
        {
            get => _javaEmbeddedServerEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _javaEmbeddedServerEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#java_version WindowsWebApp#java_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#node_version WindowsWebApp#node_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#php_version WindowsWebApp#php_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhpVersion
        {
            get;
            set;
        }

        private object? _python;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#python WindowsWebApp#python}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "python", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Python
        {
            get => _python;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _python = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#tomcat_version WindowsWebApp#tomcat_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tomcatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TomcatVersion
        {
            get;
            set;
        }
    }
}
