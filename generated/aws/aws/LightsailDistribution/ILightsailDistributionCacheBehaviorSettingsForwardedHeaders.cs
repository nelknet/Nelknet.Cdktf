using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedHeaders), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders")]
    public interface ILightsailDistributionCacheBehaviorSettingsForwardedHeaders
    {
        /// <summary>The specific headers to forward to your distribution's origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#headers_allow_list LightsailDistribution#headers_allow_list}
        /// </remarks>
        [JsiiProperty(name: "headersAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HeadersAllowList
        {
            get
            {
                return null;
            }
        }

        /// <summary>The headers that you want your distribution to forward to your origin and base caching on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
        /// </remarks>
        [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Option
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedHeaders), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The specific headers to forward to your distribution's origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#headers_allow_list LightsailDistribution#headers_allow_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headersAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HeadersAllowList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The headers that you want your distribution to forward to your origin and base caching on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "option", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Option
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
