using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection")]
    public class Wafv2WebAclDataProtectionConfigDataProtection : aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#action Wafv2WebAcl#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#field Wafv2WebAcl#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtectionField\"}")]
        public aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtectionField Field
        {
            get;
            set;
        }

        private object? _excludeRateBasedDetails;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rate_based_details Wafv2WebAcl#exclude_rate_based_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeRateBasedDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeRateBasedDetails
        {
            get => _excludeRateBasedDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeRateBasedDetails = value;
            }
        }

        private object? _excludeRuleMatchDetails;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#exclude_rule_match_details Wafv2WebAcl#exclude_rule_match_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeRuleMatchDetails", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ExcludeRuleMatchDetails
        {
            get => _excludeRuleMatchDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludeRuleMatchDetails = value;
            }
        }
    }
}
