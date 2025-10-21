using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.securityCenterAutomation.SecurityCenterAutomationSource")]
    public class SecurityCenterAutomationSource : azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#event_source SecurityCenterAutomation#event_source}.</summary>
        [JsiiProperty(name: "eventSource", typeJson: "{\"primitive\":\"string\"}")]
        public string EventSource
        {
            get;
            set;
        }

        private object? _ruleSet;

        /// <summary>rule_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#rule_set SecurityCenterAutomation#rule_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RuleSet
        {
            get => _ruleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSourceRuleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSourceRuleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ruleSet = value;
            }
        }
    }
}
