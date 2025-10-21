using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rbinRule.RbinRuleLockConfigurationUnlockDelay")]
    public class RbinRuleLockConfigurationUnlockDelay : aws.RbinRule.IRbinRuleLockConfigurationUnlockDelay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_unit RbinRule#unlock_delay_unit}.</summary>
        [JsiiProperty(name: "unlockDelayUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string UnlockDelayUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#unlock_delay_value RbinRule#unlock_delay_value}.</summary>
        [JsiiProperty(name: "unlockDelayValue", typeJson: "{\"primitive\":\"number\"}")]
        public double UnlockDelayValue
        {
            get;
            set;
        }
    }
}
