using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleOverrideAction), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction")]
    public interface IWafv2WebAclRuleOverrideAction
    {
        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#count Wafv2WebAcl#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>none block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#none Wafv2WebAcl#none}
        /// </remarks>
        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionNone\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone? None
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleOverrideAction), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclRuleOverrideAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#count Wafv2WebAcl#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionCount\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount? Count
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionCount?>();
            }

            /// <summary>none block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#none Wafv2WebAcl#none}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclRuleOverrideActionNone\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone? None
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclRuleOverrideActionNone?>();
            }
        }
    }
}
