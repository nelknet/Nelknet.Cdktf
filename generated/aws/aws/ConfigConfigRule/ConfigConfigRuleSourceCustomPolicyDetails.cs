using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configConfigRule.ConfigConfigRuleSourceCustomPolicyDetails")]
    public class ConfigConfigRuleSourceCustomPolicyDetails : aws.ConfigConfigRule.IConfigConfigRuleSourceCustomPolicyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_runtime ConfigConfigRule#policy_runtime}.</summary>
        [JsiiProperty(name: "policyRuntime", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyRuntime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#policy_text ConfigConfigRule#policy_text}.</summary>
        [JsiiProperty(name: "policyText", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyText
        {
            get;
            set;
        }

        private object? _enableDebugLogDelivery;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_config_rule#enable_debug_log_delivery ConfigConfigRule#enable_debug_log_delivery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableDebugLogDelivery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableDebugLogDelivery
        {
            get => _enableDebugLogDelivery;
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
                _enableDebugLogDelivery = value;
            }
        }
    }
}
