using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationRunbook.AutomationRunbookDraftContentLinkHash")]
    public class AutomationRunbookDraftContentLinkHash : azurerm.AutomationRunbook.IAutomationRunbookDraftContentLinkHash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#algorithm AutomationRunbook#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string Algorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#value AutomationRunbook#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
