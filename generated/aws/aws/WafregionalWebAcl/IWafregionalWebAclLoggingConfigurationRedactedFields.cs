using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    [JsiiInterface(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields")]
    public interface IWafregionalWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#field_to_match WafregionalWebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        object FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#field_to_match WafregionalWebAcl#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
            public object FieldToMatch
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
