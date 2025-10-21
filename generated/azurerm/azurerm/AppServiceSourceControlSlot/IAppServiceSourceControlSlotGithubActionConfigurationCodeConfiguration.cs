using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControlSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration")]
    public interface IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration
    {
        /// <summary>The value to use for the Runtime Stack in the workflow file content for code base apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#runtime_stack AppServiceSourceControlSlot#runtime_stack}
        /// </remarks>
        [JsiiProperty(name: "runtimeStack", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeStack
        {
            get;
        }

        /// <summary>The value to use for the Runtime Version in the workflow file content for code base apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#runtime_version AppServiceSourceControlSlot#runtime_version}
        /// </remarks>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The value to use for the Runtime Stack in the workflow file content for code base apps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#runtime_stack AppServiceSourceControlSlot#runtime_stack}
            /// </remarks>
            [JsiiProperty(name: "runtimeStack", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeStack
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value to use for the Runtime Version in the workflow file content for code base apps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#runtime_version AppServiceSourceControlSlot#runtime_version}
            /// </remarks>
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
