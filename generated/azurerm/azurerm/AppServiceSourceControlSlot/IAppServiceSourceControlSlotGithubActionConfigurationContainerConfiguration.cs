using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControlSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration")]
    public interface IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration
    {
        /// <summary>The image name for the build.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#image_name AppServiceSourceControlSlot#image_name}
        /// </remarks>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        string ImageName
        {
            get;
        }

        /// <summary>The server URL for the container registry where the build will be hosted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_url AppServiceSourceControlSlot#registry_url}
        /// </remarks>
        [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryUrl
        {
            get;
        }

        /// <summary>The password used to upload the image to the container registry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_password AppServiceSourceControlSlot#registry_password}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_username AppServiceSourceControlSlot#registry_username}
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

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The image name for the build.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#image_name AppServiceSourceControlSlot#image_name}
            /// </remarks>
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The server URL for the container registry where the build will be hosted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_url AppServiceSourceControlSlot#registry_url}
            /// </remarks>
            [JsiiProperty(name: "registryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The password used to upload the image to the container registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_password AppServiceSourceControlSlot#registry_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "registryPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The username used to upload the image to the container registry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#registry_username AppServiceSourceControlSlot#registry_username}
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
