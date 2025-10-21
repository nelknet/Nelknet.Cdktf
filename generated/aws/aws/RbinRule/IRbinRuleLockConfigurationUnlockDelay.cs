using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiInterface(nativeType: typeof(IRbinRuleLockConfigurationUnlockDelay), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfigurationUnlockDelay")]
    public interface IRbinRuleLockConfigurationUnlockDelay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_unit RbinRule#unlock_delay_unit}.</summary>
        [JsiiProperty(name: "unlockDelayUnit", typeJson: "{\"primitive\":\"string\"}")]
        string UnlockDelayUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_value RbinRule#unlock_delay_value}.</summary>
        [JsiiProperty(name: "unlockDelayValue", typeJson: "{\"primitive\":\"number\"}")]
        double UnlockDelayValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRbinRuleLockConfigurationUnlockDelay), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfigurationUnlockDelay")]
        internal sealed class _Proxy : DeputyBase, aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_unit RbinRule#unlock_delay_unit}.</summary>
            [JsiiProperty(name: "unlockDelayUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string UnlockDelayUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_value RbinRule#unlock_delay_value}.</summary>
            [JsiiProperty(name: "unlockDelayValue", typeJson: "{\"primitive\":\"number\"}")]
            public double UnlockDelayValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
