using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiByValue(fqn: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders")]
    public class LightsailDistributionCacheBehaviorSettingsForwardedHeaders : aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders
    {
        /// <summary>The specific headers to forward to your distribution's origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#headers_allow_list LightsailDistribution#headers_allow_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headersAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HeadersAllowList
        {
            get;
            set;
        }

        /// <summary>The headers that you want your distribution to forward to your origin and base caching on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Option
        {
            get;
            set;
        }
    }
}
