using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiByValue(fqn: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings")]
    public class LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings : aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings
    {
        private object? _option;

        /// <summary>Indicates whether the distribution forwards and caches based on query strings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Option
        {
            get => _option;
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
                _option = value;
            }
        }

        /// <summary>The specific query strings that the distribution forwards to the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#query_strings_allowed_list LightsailDistribution#query_strings_allowed_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringsAllowedList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QueryStringsAllowedList
        {
            get;
            set;
        }
    }
}
