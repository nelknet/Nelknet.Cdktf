using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiInterface(nativeType: typeof(IAutomationRunbookPublishContentLinkHash), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookPublishContentLinkHash")]
    public interface IAutomationRunbookPublishContentLinkHash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#algorithm AutomationRunbook#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        string Algorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#value AutomationRunbook#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationRunbookPublishContentLinkHash), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookPublishContentLinkHash")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationRunbook.IAutomationRunbookPublishContentLinkHash
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#algorithm AutomationRunbook#algorithm}.</summary>
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string Algorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#value AutomationRunbook#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
