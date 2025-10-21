using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiInterface(nativeType: typeof(IAutomationRunbookDraft), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookDraft")]
    public interface IAutomationRunbookDraft
    {
        /// <summary>content_link block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#content_link AutomationRunbook#content_link}
        /// </remarks>
        [JsiiProperty(name: "contentLink", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLink\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink? ContentLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#edit_mode_enabled AutomationRunbook#edit_mode_enabled}.</summary>
        [JsiiProperty(name: "editModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EditModeEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#output_types AutomationRunbook#output_types}.</summary>
        [JsiiProperty(name: "outputTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OutputTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#parameters AutomationRunbook#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationRunbookDraft), fullyQualifiedName: "azurerm.automationRunbook.AutomationRunbookDraft")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationRunbook.IAutomationRunbookDraft
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content_link block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#content_link AutomationRunbook#content_link}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentLink", typeJson: "{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftContentLink\"}", isOptional: true)]
            public azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink? ContentLink
            {
                get => GetInstanceProperty<azurerm.AutomationRunbook.IAutomationRunbookDraftContentLink?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#edit_mode_enabled AutomationRunbook#edit_mode_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "editModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EditModeEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#output_types AutomationRunbook#output_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OutputTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#parameters AutomationRunbook#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationRunbook.AutomationRunbookDraftParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
