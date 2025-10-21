using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDataProtectionConfigDataProtectionField), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField")]
    public interface IWafv2WebAclDataProtectionConfigDataProtectionField
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_type Wafv2WebAcl#field_type}.</summary>
        [JsiiProperty(name: "fieldType", typeJson: "{\"primitive\":\"string\"}")]
        string FieldType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_keys Wafv2WebAcl#field_keys}.</summary>
        [JsiiProperty(name: "fieldKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FieldKeys
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDataProtectionConfigDataProtectionField), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_type Wafv2WebAcl#field_type}.</summary>
            [JsiiProperty(name: "fieldType", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field_keys Wafv2WebAcl#field_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FieldKeys
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
