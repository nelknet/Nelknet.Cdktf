using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControlSlot
{
    [JsiiByValue(fqn: "azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration")]
    public class AppServiceSourceControlSlotGithubActionConfiguration : azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfiguration
    {
        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#code_configuration AppServiceSourceControlSlot#code_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
        public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationCodeConfiguration? CodeConfiguration
        {
            get;
            set;
        }

        /// <summary>container_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#container_configuration AppServiceSourceControlSlot#container_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
        public azurerm.AppServiceSourceControlSlot.IAppServiceSourceControlSlotGithubActionConfigurationContainerConfiguration? ContainerConfiguration
        {
            get;
            set;
        }

        private object? _generateWorkflowFile;

        /// <summary>Should the service generate the GitHub Action Workflow file. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#generate_workflow_file AppServiceSourceControlSlot#generate_workflow_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generateWorkflowFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? GenerateWorkflowFile
        {
            get => _generateWorkflowFile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _generateWorkflowFile = value;
            }
        }
    }
}
