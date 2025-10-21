using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configConfigRule.ConfigConfigRuleSource")]
    public class ConfigConfigRuleSource : aws.ConfigConfigRule.IConfigConfigRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#owner ConfigConfigRule#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public string Owner
        {
            get;
            set;
        }

        /// <summary>custom_policy_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#custom_policy_details ConfigConfigRule#custom_policy_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customPolicyDetails", typeJson: "{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails\"}", isOptional: true)]
        public aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails? CustomPolicyDetails
        {
            get;
            set;
        }

        private object? _sourceDetail;

        /// <summary>source_detail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_detail ConfigConfigRule#source_detail}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConfigRule.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceDetail
        {
            get => _sourceDetail;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ConfigConfigRule.IConfigConfigRuleSourceSourceDetail).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceDetail = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceIdentifier
        {
            get;
            set;
        }
    }
}
