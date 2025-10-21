using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDataProtectionConfigDataProtection), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection")]
    public interface IWafv2WebAclDataProtectionConfigDataProtection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field Wafv2WebAcl#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField\"}")]
        aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField Field
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rate_based_details Wafv2WebAcl#exclude_rate_based_details}.</summary>
        [JsiiProperty(name: "excludeRateBasedDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeRateBasedDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rule_match_details Wafv2WebAcl#exclude_rule_match_details}.</summary>
        [JsiiProperty(name: "excludeRuleMatchDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeRuleMatchDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDataProtectionConfigDataProtection), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field Wafv2WebAcl#field}
            /// </remarks>
            [JsiiProperty(name: "field", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField\"}")]
            public aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField Field
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rate_based_details Wafv2WebAcl#exclude_rate_based_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeRateBasedDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeRateBasedDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rule_match_details Wafv2WebAcl#exclude_rule_match_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeRuleMatchDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeRuleMatchDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
