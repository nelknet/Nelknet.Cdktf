using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSiteConfigApplicationStack), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigApplicationStack")]
    public interface ILinuxWebAppSiteConfigApplicationStack
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_image_name LinuxWebApp#docker_image_name}.</summary>
        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerImageName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_password LinuxWebApp#docker_registry_password}.</summary>
        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_url LinuxWebApp#docker_registry_url}.</summary>
        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_username LinuxWebApp#docker_registry_username}.</summary>
        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DockerRegistryUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#dotnet_version LinuxWebApp#dotnet_version}.</summary>
        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DotnetVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#go_version LinuxWebApp#go_version}.</summary>
        [JsiiProperty(name: "goVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GoVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_server LinuxWebApp#java_server}.</summary>
        [JsiiProperty(name: "javaServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_server_version LinuxWebApp#java_server_version}.</summary>
        [JsiiProperty(name: "javaServerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaServerVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_version LinuxWebApp#java_version}.</summary>
        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JavaVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#node_version LinuxWebApp#node_version}.</summary>
        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#php_version LinuxWebApp#php_version}.</summary>
        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhpVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#python_version LinuxWebApp#python_version}.</summary>
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PythonVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#ruby_version LinuxWebApp#ruby_version}.</summary>
        [JsiiProperty(name: "rubyVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RubyVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSiteConfigApplicationStack), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigApplicationStack")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppSiteConfigApplicationStack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_image_name LinuxWebApp#docker_image_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerImageName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_password LinuxWebApp#docker_registry_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_url LinuxWebApp#docker_registry_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#docker_registry_username LinuxWebApp#docker_registry_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DockerRegistryUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#dotnet_version LinuxWebApp#dotnet_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DotnetVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#go_version LinuxWebApp#go_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "goVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GoVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_server LinuxWebApp#java_server}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaServer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_server_version LinuxWebApp#java_server_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaServerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaServerVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#java_version LinuxWebApp#java_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JavaVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#node_version LinuxWebApp#node_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#php_version LinuxWebApp#php_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhpVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#python_version LinuxWebApp#python_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PythonVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#ruby_version LinuxWebApp#ruby_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rubyVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RubyVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
