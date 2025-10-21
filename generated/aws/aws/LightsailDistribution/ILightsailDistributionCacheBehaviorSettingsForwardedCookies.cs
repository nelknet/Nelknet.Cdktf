using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedCookies), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies")]
    public interface ILightsailDistributionCacheBehaviorSettingsForwardedCookies
    {
        /// <summary>The specific cookies to forward to your distribution's origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cookies_allow_list LightsailDistribution#cookies_allow_list}
        /// </remarks>
        [JsiiProperty(name: "cookiesAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CookiesAllowList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies which cookies to forward to the distribution's origin for a cache behavior: all, none, or allow-list to forward only the cookies specified in the cookiesAllowList parameter.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedCookies), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The specific cookies to forward to your distribution's origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cookies_allow_list LightsailDistribution#cookies_allow_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookiesAllowList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CookiesAllowList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Specifies which cookies to forward to the distribution's origin for a cache behavior: all, none, or allow-list to forward only the cookies specified in the cookiesAllowList parameter.</summary>
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
