using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiInterface(nativeType: typeof(IRbinRuleLockConfiguration), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfiguration")]
    public interface IRbinRuleLockConfiguration
    {
        /// <summary>unlock_delay block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay RbinRule#unlock_delay}
        /// </remarks>
        [JsiiProperty(name: "unlockDelay", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}")]
        aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay UnlockDelay
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRbinRuleLockConfiguration), fullyQualifiedName: "aws.rbinRule.RbinRuleLockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.RbinRule.IRbinRuleLockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>unlock_delay block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay RbinRule#unlock_delay}
            /// </remarks>
            [JsiiProperty(name: "unlockDelay", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}")]
            public aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay UnlockDelay
            {
                get => GetInstanceProperty<aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay>()!;
            }
        }
    }
}
