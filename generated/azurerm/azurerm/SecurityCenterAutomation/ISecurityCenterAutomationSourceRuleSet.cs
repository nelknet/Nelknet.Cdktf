using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    [JsiiInterface(nativeType: typeof(ISecurityCenterAutomationSourceRuleSet), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSet")]
    public interface ISecurityCenterAutomationSourceRuleSet
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#rule SecurityCenterAutomation#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSetRule\"},\"kind\":\"array\"}}]}}")]
        object Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityCenterAutomationSourceRuleSet), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSet")]
        internal sealed class _Proxy : DeputyBase, azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSourceRuleSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#rule SecurityCenterAutomation#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSetRule\"},\"kind\":\"array\"}}]}}")]
            public object Rule
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
