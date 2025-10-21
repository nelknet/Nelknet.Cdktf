using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiInterface(nativeType: typeof(IAutomationRunbookDraftContentLink), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookDraftContentLink")]
    public interface IAutomationRunbookDraftContentLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#uri AutomationRunbook#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#hash AutomationRunbook#hash}
        /// </remarks>
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLinkHash\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomationRunbook.IAutomationRunbookDraftContentLinkHash? Hash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#version AutomationRunbook#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationRunbookDraftContentLink), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookDraftContentLink")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#uri AutomationRunbook#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#hash AutomationRunbook#hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLinkHash\"}", isOptional: true)]
            public azurerm.AutomationRunbook.IAutomationRunbookDraftContentLinkHash? Hash
            {
                get => GetInstanceProperty<azurerm.AutomationRunbook.IAutomationRunbookDraftContentLinkHash?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#version AutomationRunbook#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
