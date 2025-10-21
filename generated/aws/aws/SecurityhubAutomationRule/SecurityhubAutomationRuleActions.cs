using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleActions")]
    public class SecurityhubAutomationRuleActions : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActions
    {
        private object? _findingFieldsUpdate;

        /// <summary>finding_fields_update block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#finding_fields_update SecurityhubAutomationRule#finding_fields_update}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingFieldsUpdate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleActionsFindingFieldsUpdate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingFieldsUpdate
        {
            get => _findingFieldsUpdate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleActionsFindingFieldsUpdate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingFieldsUpdate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#type SecurityhubAutomationRule#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
