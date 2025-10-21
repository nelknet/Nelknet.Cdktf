using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleCaptchaConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig")]
    public interface IWafv2WebAclRuleCaptchaConfig
    {
        /// <summary>immunity_time_property block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time_property Wafv2WebAcl#immunity_time_property}
        /// </remarks>
        [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigImmunityTimeProperty\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleCaptchaConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>immunity_time_property block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#immunity_time_property Wafv2WebAcl#immunity_time_property}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immunityTimeProperty", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleCaptchaConfigImmunityTimeProperty\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleCaptchaConfigImmunityTimeProperty?>();
            }
        }
    }
}
