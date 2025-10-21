using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RbinRule
{
    [JsiiInterface(nativeType: typeof(IRbinRuleResourceTags), fullyQualifiedName: "aws.rbinRule.RbinRuleResourceTags")]
    public interface IRbinRuleResourceTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_key RbinRule#resource_tag_key}.</summary>
        [JsiiProperty(name: "resourceTagKey", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceTagKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_value RbinRule#resource_tag_value}.</summary>
        [JsiiProperty(name: "resourceTagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceTagValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRbinRuleResourceTags), fullyQualifiedName: "aws.rbinRule.RbinRuleResourceTags")]
        internal sealed class _Proxy : DeputyBase, aws.RbinRule.IRbinRuleResourceTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_key RbinRule#resource_tag_key}.</summary>
            [JsiiProperty(name: "resourceTagKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceTagKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rbin_rule#resource_tag_value RbinRule#resource_tag_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceTagValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
