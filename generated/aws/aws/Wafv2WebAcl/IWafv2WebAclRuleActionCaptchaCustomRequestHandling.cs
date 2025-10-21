using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionCaptchaCustomRequestHandling), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandling")]
    public interface IWafv2WebAclRuleActionCaptchaCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}]}}")]
        object InsertHeader
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionCaptchaCustomRequestHandling), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandling")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleActionCaptchaCustomRequestHandling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>insert_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
            /// </remarks>
            [JsiiProperty(name: "insertHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleActionCaptchaCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}]}}")]
            public object InsertHeader
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
