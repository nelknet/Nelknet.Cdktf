using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rbinRule.RbinRuleRetentionPeriod")]
    public class RbinRuleRetentionPeriod : aws.RbinRule.IRbinRuleRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_unit RbinRule#retention_period_unit}.</summary>
        [JsiiProperty(name: "retentionPeriodUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string RetentionPeriodUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_value RbinRule#retention_period_value}.</summary>
        [JsiiProperty(name: "retentionPeriodValue", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionPeriodValue
        {
            get;
            set;
        }
    }
}
