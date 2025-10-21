using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    [JsiiInterface(nativeType: typeof(ISecurityCenterAutomationSource), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSource")]
    public interface ISecurityCenterAutomationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#event_source SecurityCenterAutomation#event_source}.</summary>
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}")]
        string EventSource
        {
            get;
        }

        /// <summary>rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#rule_set SecurityCenterAutomation#rule_set}
        /// </remarks>
        [JsiiProperty(name: "ruleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityCenterAutomationSource), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#event_source SecurityCenterAutomation#event_source}.</summary>
            [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}")]
            public string EventSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rule_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#rule_set SecurityCenterAutomation#rule_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RuleSet
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
