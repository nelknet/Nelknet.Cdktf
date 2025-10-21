using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDataProtectionConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfig")]
    public interface IWafv2WebAclDataProtectionConfig
    {
        /// <summary>data_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#data_protection Wafv2WebAcl#data_protection}
        /// </remarks>
        [JsiiProperty(name: "dataProtection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDataProtectionConfig), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#data_protection Wafv2WebAcl#data_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataProtection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataProtection
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
