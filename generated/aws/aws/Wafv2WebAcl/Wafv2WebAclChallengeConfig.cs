using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclChallengeConfig")]
    public class Wafv2WebAclChallengeConfig : aws.Wafv2WebAcl.IWafv2WebAclChallengeConfig
    {
        /// <summary>immunity_time_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time_property Wafv2WebAcl#immunity_time_property}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimeProperty\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty? ImmunityTimeProperty
        {
            get;
            set;
        }
    }
}
