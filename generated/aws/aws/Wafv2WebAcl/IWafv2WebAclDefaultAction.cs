using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDefaultAction")]
    public interface IWafv2WebAclDefaultAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclDefaultActionAllow? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#block Wafv2WebAcl#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlock? Block
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#allow Wafv2WebAcl#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclDefaultActionAllow? Allow
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDefaultActionAllow?>();
            }

            /// <summary>block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#block Wafv2WebAcl#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlock? Block
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDefaultActionBlock?>();
            }
        }
    }
}
