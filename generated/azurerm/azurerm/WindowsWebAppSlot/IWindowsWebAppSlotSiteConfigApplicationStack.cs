using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigApplicationStack")]
    public interface IWindowsWebAppSlotSiteConfigApplicationStack
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#current_stack WindowsWebAppSlot#current_stack}.</summary>
        [JsiiProperty(name: "currentStack", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CurrentStack
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_image_name WindowsWebAppSlot#docker_image_name}.</summary>
        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerImageName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_password WindowsWebAppSlot#docker_registry_password}.</summary>
        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_url WindowsWebAppSlot#docker_registry_url}.</summary>
        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_username WindowsWebAppSlot#docker_registry_username}.</summary>
        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of DotNetCore to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_core_version WindowsWebAppSlot#dotnet_core_version}
        /// </remarks>
        [JsiiProperty(name: "dotnetCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DotnetCoreVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_version WindowsWebAppSlot#dotnet_version}.</summary>
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DotnetVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container WindowsWebAppSlot#java_container}.</summary>
        [JsiiProperty(name: "javaContainer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaContainer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container_version WindowsWebAppSlot#java_container_version}.</summary>
        [JsiiProperty(name: "javaContainerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaContainerVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the application use the embedded web server for the version of Java in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_embedded_server_enabled WindowsWebAppSlot#java_embedded_server_enabled}
        /// </remarks>
        [JsiiProperty(name: "javaEmbeddedServerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JavaEmbeddedServerEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_version WindowsWebAppSlot#java_version}.</summary>
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#node_version WindowsWebAppSlot#node_version}.</summary>
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#php_version WindowsWebAppSlot#php_version}.</summary>
        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#python WindowsWebAppSlot#python}.</summary>
        [JsiiProperty(name: "python", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Python
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#tomcat_version WindowsWebAppSlot#tomcat_version}.</summary>
        [JsiiProperty(name: "tomcatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TomcatVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotSiteConfigApplicationStack), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigApplicationStack")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigApplicationStack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#current_stack WindowsWebAppSlot#current_stack}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currentStack", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CurrentStack
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_image_name WindowsWebAppSlot#docker_image_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerImageName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_password WindowsWebAppSlot#docker_registry_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_url WindowsWebAppSlot#docker_registry_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#docker_registry_username WindowsWebAppSlot#docker_registry_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The version of DotNetCore to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_core_version WindowsWebAppSlot#dotnet_core_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dotnetCoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DotnetCoreVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#dotnet_version WindowsWebAppSlot#dotnet_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DotnetVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container WindowsWebAppSlot#java_container}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaContainer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaContainer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_container_version WindowsWebAppSlot#java_container_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaContainerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaContainerVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Should the application use the embedded web server for the version of Java in use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_embedded_server_enabled WindowsWebAppSlot#java_embedded_server_enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaEmbeddedServerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? JavaEmbeddedServerEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#java_version WindowsWebAppSlot#java_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#node_version WindowsWebAppSlot#node_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#php_version WindowsWebAppSlot#php_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#python WindowsWebAppSlot#python}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "python", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Python
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#tomcat_version WindowsWebAppSlot#tomcat_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tomcatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TomcatVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
