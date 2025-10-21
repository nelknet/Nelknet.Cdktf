using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiByValue(fqn: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAt")]
    public class SecurityhubAutomationRuleCriteriaCreatedAt : aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt
    {
        private object? _dateRange;

        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#date_range SecurityhubAutomationRule#date_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAtDateRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DateRange
        {
            get => _dateRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAtDateRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAtDateRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dateRange = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#end SecurityhubAutomationRule#end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_automation_rule#start SecurityhubAutomationRule#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
