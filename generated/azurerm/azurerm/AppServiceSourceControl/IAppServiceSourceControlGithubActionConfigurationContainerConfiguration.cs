using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlGithubActionConfigurationContainerConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration")]
    public interface IAppServiceSourceControlGithubActionConfigurationContainerConfiguration
    {
        /// <summary>The image name for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#image_name AppServiceSourceControlA#image_name}
        /// </remarks>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        string ImageName
        {
            get;
        }

        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_url AppServiceSourceControlA#registry_url}
        /// </remarks>
        [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryUrl
        {
            get;
        }

        /// <summary>The password used to upload the image to the container registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_password AppServiceSourceControlA#registry_password}
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

        /// <summary>The username used to upload the image to the container registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_username AppServiceSourceControlA#registry_username}
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

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlGithubActionConfigurationContainerConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The image name for the build.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#image_name AppServiceSourceControlA#image_name}
            /// </remarks>
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The server URL for the container registry where the build will be hosted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_url AppServiceSourceControlA#registry_url}
            /// </remarks>
            [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The password used to upload the image to the container registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_password AppServiceSourceControlA#registry_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username used to upload the image to the container registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#registry_username AppServiceSourceControlA#registry_username}
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
