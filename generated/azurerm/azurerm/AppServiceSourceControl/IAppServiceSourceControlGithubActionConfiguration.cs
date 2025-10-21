using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlGithubActionConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfiguration")]
    public interface IAppServiceSourceControlGithubActionConfiguration
    {
        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#code_configuration AppServiceSourceControlA#code_configuration}
        /// </remarks>
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration? CodeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#container_configuration AppServiceSourceControlA#container_configuration}
        /// </remarks>
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration? ContainerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#generate_workflow_file AppServiceSourceControlA#generate_workflow_file}
        /// </remarks>
        [JsiiProperty(name: "generateWorkflowFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GenerateWorkflowFile
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlGithubActionConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>code_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#code_configuration AppServiceSourceControlA#code_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
            public azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration? CodeConfiguration
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration?>();
            }

            /// <summary>container_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#container_configuration AppServiceSourceControlA#container_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
            public azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration? ContainerConfiguration
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration?>();
            }

            /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#generate_workflow_file AppServiceSourceControlA#generate_workflow_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generateWorkflowFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? GenerateWorkflowFile
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
