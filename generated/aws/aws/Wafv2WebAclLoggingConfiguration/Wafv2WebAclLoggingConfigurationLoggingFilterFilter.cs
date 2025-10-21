using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAclLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationLoggingFilterFilter")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilterFilter : aws.Wafv2WebAclLoggingConfiguration.IWafv2WebAclLoggingConfigurationLoggingFilterFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#behavior Wafv2WebAclLoggingConfiguration#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public string Behavior
        {
            get;
            set;
        }

        private object _condition;

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#condition Wafv2WebAclLoggingConfiguration#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAclLoggingConfiguration.Wafv2WebAclLoggingConfigurationLoggingFilterFilterCondition\"},\"kind\":\"array\"}}]}}")]
        public object Condition
        {
            get => _condition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAclLoggingConfiguration.IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAclLoggingConfiguration.IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAclLoggingConfiguration.IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _condition = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl_logging_configuration#requirement Wafv2WebAclLoggingConfiguration#requirement}.</summary>
        [JsiiProperty(name: "requirement", typeJson: "{\"primitive\":\"string\"}")]
        public string Requirement
        {
            get;
            set;
        }
    }
}
