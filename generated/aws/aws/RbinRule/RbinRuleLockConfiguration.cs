using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rbinRule.RbinRuleLockConfiguration")]
    public class RbinRuleLockConfiguration : aws.RbinRule.IRbinRuleLockConfiguration
    {
        /// <summary>unlock_delay block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay RbinRule#unlock_delay}
        /// </remarks>
        [JsiiProperty(name: "unlockDelay", typeJson: "{\"fqn\":\"aws.rbinRule.RbinRuleLockConfigurationUnlockDelay\"}")]
        public aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay UnlockDelay
        {
            get;
            set;
        }
    }
}
