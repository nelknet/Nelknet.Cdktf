using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclChallengeConfigImmunityTimeProperty")]
    public class Wafv2WebAclChallengeConfigImmunityTimeProperty : aws.Wafv2WebAcl.IWafv2WebAclChallengeConfigImmunityTimeProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time Wafv2WebAcl#immunity_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImmunityTime
        {
            get;
            set;
        }
    }
}
