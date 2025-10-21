using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiInterface(nativeType: typeof(IRbinRuleRetentionPeriod), fullyQualifiedName: "aws.rbinRule.RbinRuleRetentionPeriod")]
    public interface IRbinRuleRetentionPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_unit RbinRule#retention_period_unit}.</summary>
        [JsiiProperty(name: "retentionPeriodUnit", typeJson: "{\"primitive\":\"string\"}")]
        string RetentionPeriodUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_value RbinRule#retention_period_value}.</summary>
        [JsiiProperty(name: "retentionPeriodValue", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionPeriodValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRbinRuleRetentionPeriod), fullyQualifiedName: "aws.rbinRule.RbinRuleRetentionPeriod")]
        internal sealed class _Proxy : DeputyBase, aws.RbinRule.IRbinRuleRetentionPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_unit RbinRule#retention_period_unit}.</summary>
            [JsiiProperty(name: "retentionPeriodUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string RetentionPeriodUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#retention_period_value RbinRule#retention_period_value}.</summary>
            [JsiiProperty(name: "retentionPeriodValue", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionPeriodValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
