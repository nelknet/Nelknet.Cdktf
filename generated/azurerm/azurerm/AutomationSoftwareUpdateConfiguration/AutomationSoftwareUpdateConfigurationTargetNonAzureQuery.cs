using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    [JsiiByValue(fqn: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery")]
    public class AutomationSoftwareUpdateConfigurationTargetNonAzureQuery : azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#function_alias AutomationSoftwareUpdateConfiguration#function_alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionAlias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionAlias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#workspace_id AutomationSoftwareUpdateConfiguration#workspace_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkspaceId
        {
            get;
            set;
        }
    }
}
