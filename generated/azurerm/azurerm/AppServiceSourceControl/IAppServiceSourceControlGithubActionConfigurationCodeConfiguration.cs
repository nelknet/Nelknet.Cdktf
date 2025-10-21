using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlGithubActionConfigurationCodeConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration")]
    public interface IAppServiceSourceControlGithubActionConfigurationCodeConfiguration
    {
        /// <summary>The value to use for the Runtime Stack in the workflow file content for code base apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#runtime_stack AppServiceSourceControlA#runtime_stack}
        /// </remarks>
        [JsiiProperty(name: "runtimeStack", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeStack
        {
            get;
        }

        /// <summary>The value to use for the Runtime Version in the workflow file content for code base apps.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#runtime_version AppServiceSourceControlA#runtime_version}
        /// </remarks>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlGithubActionConfigurationCodeConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The value to use for the Runtime Stack in the workflow file content for code base apps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#runtime_stack AppServiceSourceControlA#runtime_stack}
            /// </remarks>
            [JsiiProperty(name: "runtimeStack", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeStack
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The value to use for the Runtime Version in the workflow file content for code base apps.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#runtime_version AppServiceSourceControlA#runtime_version}
            /// </remarks>
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
