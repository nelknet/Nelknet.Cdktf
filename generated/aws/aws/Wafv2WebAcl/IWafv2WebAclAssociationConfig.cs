using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclAssociationConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfig")]
    public interface IWafv2WebAclAssociationConfig
    {
        /// <summary>request_body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#request_body Wafv2WebAcl#request_body}
        /// </remarks>
        [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestBody
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclAssociationConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>request_body block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#request_body Wafv2WebAcl#request_body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestBody
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
