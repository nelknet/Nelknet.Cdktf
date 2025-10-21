using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigImmunityTimeProperty")]
    public interface IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time Wafv2WebAcl#immunity_time}.</summary>
        [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImmunityTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigImmunityTimeProperty")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time Wafv2WebAcl#immunity_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImmunityTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
