using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionCaptcha), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptcha")]
    public interface IWafv2WebAclRuleActionCaptcha
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
        /// </remarks>
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptchaCustomRequestHandling? CustomRequestHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionCaptcha), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptcha")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptcha
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_request_handling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandling\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptchaCustomRequestHandling? CustomRequestHandling
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptchaCustomRequestHandling?>();
            }
        }
    }
}
