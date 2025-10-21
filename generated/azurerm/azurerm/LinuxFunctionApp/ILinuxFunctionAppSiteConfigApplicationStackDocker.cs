using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSiteConfigApplicationStackDocker), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigApplicationStackDocker")]
    public interface ILinuxFunctionAppSiteConfigApplicationStackDocker
    {
        /// <summary>The name of the Docker image to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_name LinuxFunctionApp#image_name}
        /// </remarks>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        string ImageName
        {
            get;
        }

        /// <summary>The image tag of the image to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_tag LinuxFunctionApp#image_tag}
        /// </remarks>
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}")]
        string ImageTag
        {
            get;
        }

        /// <summary>The URL of the docker registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_url LinuxFunctionApp#registry_url}
        /// </remarks>
        [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryUrl
        {
            get;
        }

        /// <summary>The password for the account to use to connect to the registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_password LinuxFunctionApp#registry_password}
        /// </remarks>
        [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>The username to use for connections to the registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_username LinuxFunctionApp#registry_username}
        /// </remarks>
        [JsiiProperty(name: "registryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryUsername
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSiteConfigApplicationStackDocker), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigApplicationStackDocker")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigApplicationStackDocker
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the Docker image to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_name LinuxFunctionApp#image_name}
            /// </remarks>
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The image tag of the image to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_tag LinuxFunctionApp#image_tag}
            /// </remarks>
            [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageTag
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The URL of the docker registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_url LinuxFunctionApp#registry_url}
            /// </remarks>
            [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The password for the account to use to connect to the registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_password LinuxFunctionApp#registry_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username to use for connections to the registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_username LinuxFunctionApp#registry_username}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryUsername
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
