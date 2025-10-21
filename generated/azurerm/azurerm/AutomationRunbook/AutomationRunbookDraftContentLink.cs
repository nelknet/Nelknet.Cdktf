using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationRunbook.AutomationRunbookDraftContentLink")]
    public class AutomationRunbookDraftContentLink : azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#uri AutomationRunbook#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#hash AutomationRunbook#hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLinkHash\"}", isOptional: true)]
        public azurerm.AutomationRunbook.IAutomationRunbookDraftContentLinkHash? Hash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#version AutomationRunbook#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
