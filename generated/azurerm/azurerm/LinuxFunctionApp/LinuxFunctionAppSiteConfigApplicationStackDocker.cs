using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigApplicationStackDocker")]
    public class LinuxFunctionAppSiteConfigApplicationStackDocker : azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigApplicationStackDocker
    {
        /// <summary>The name of the Docker image to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_name LinuxFunctionApp#image_name}
        /// </remarks>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>The image tag of the image to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#image_tag LinuxFunctionApp#image_tag}
        /// </remarks>
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}")]
        public string ImageTag
        {
            get;
            set;
        }

        /// <summary>The URL of the docker registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_url LinuxFunctionApp#registry_url}
        /// </remarks>
        [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryUrl
        {
            get;
            set;
        }

        /// <summary>The password for the account to use to connect to the registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_password LinuxFunctionApp#registry_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryPassword
        {
            get;
            set;
        }

        /// <summary>The username to use for connections to the registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#registry_username LinuxFunctionApp#registry_username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryUsername
        {
            get;
            set;
        }
    }
}
