using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigApplicationStack")]
    public class WindowsWebAppSlotSiteConfigApplicationStack : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigApplicationStack
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#current_stack WindowsWebAppSlot#current_stack}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currentStack", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CurrentStack
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_image_name WindowsWebAppSlot#docker_image_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerImageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_password WindowsWebAppSlot#docker_registry_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_url WindowsWebAppSlot#docker_registry_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_username WindowsWebAppSlot#docker_registry_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DockerRegistryUsername
        {
            get;
            set;
        }

        /// <summary>The version of DotNetCore to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_core_version WindowsWebAppSlot#dotnet_core_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetCoreVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_version WindowsWebAppSlot#dotnet_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DotnetVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container WindowsWebAppSlot#java_container}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "javaContainer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaContainer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container_version WindowsWebAppSlot#java_container_version}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_embedded_server_enabled WindowsWebAppSlot#java_embedded_server_enabled}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_version WindowsWebAppSlot#java_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JavaVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#node_version WindowsWebAppSlot#node_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#php_version WindowsWebAppSlot#php_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhpVersion
        {
            get;
            set;
        }

        private object? _python;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#python WindowsWebAppSlot#python}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#tomcat_version WindowsWebAppSlot#tomcat_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tomcatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TomcatVersion
        {
            get;
            set;
        }
    }
}
