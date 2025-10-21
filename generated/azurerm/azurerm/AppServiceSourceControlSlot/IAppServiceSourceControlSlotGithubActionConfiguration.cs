using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControlSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration")]
    public interface IAppServiceSourceControlSlotGithubActionConfiguration
    {
        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#code_configuration AppServiceSourceControlSlot#code_configuration}
        /// </remarks>
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration? CodeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#container_configuration AppServiceSourceControlSlot#container_configuration}
        /// </remarks>
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration? ContainerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#generate_workflow_file AppServiceSourceControlSlot#generate_workflow_file}
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

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSourceControlSlotGithubActionConfiguration), fullyQualifiedName: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>code_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#code_configuration AppServiceSourceControlSlot#code_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
            public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration? CodeConfiguration
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration?>();
            }

            /// <summary>container_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#container_configuration AppServiceSourceControlSlot#container_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
            public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration? ContainerConfiguration
            {
                get => GetInstanceProperty<azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration?>();
            }

            /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#generate_workflow_file AppServiceSourceControlSlot#generate_workflow_file}
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
