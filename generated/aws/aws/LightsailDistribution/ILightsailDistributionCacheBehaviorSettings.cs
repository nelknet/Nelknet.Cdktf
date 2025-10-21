using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionCacheBehaviorSettings), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettings")]
    public interface ILightsailDistributionCacheBehaviorSettings
    {
        /// <summary>The HTTP methods that are processed and forwarded to the distribution's origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#allowed_http_methods LightsailDistribution#allowed_http_methods}
        /// </remarks>
        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedHttpMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP method responses that are cached by your distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cached_http_methods LightsailDistribution#cached_http_methods}
        /// </remarks>
        [JsiiProperty(name: "cachedHttpMethods", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachedHttpMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the content has been updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#default_ttl LightsailDistribution#default_ttl}
        /// </remarks>
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarded_cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_cookies LightsailDistribution#forwarded_cookies}
        /// </remarks>
        [JsiiProperty(name: "forwardedCookies", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies? ForwardedCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarded_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_headers LightsailDistribution#forwarded_headers}
        /// </remarks>
        [JsiiProperty(name: "forwardedHeaders", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders? ForwardedHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarded_query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_query_strings LightsailDistribution#forwarded_query_strings}
        /// </remarks>
        [JsiiProperty(name: "forwardedQueryStrings", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings? ForwardedQueryStrings
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the object has been updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#maximum_ttl LightsailDistribution#maximum_ttl}
        /// </remarks>
        [JsiiProperty(name: "maximumTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the object has been updated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#minimum_ttl LightsailDistribution#minimum_ttl}
        /// </remarks>
        [JsiiProperty(name: "minimumTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionCacheBehaviorSettings), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettings")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP methods that are processed and forwarded to the distribution's origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#allowed_http_methods LightsailDistribution#allowed_http_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedHttpMethods
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The HTTP method responses that are cached by your distribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#cached_http_methods LightsailDistribution#cached_http_methods}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cachedHttpMethods", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CachedHttpMethods
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The default amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the content has been updated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#default_ttl LightsailDistribution#default_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>forwarded_cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_cookies LightsailDistribution#forwarded_cookies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedCookies", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies\"}", isOptional: true)]
            public aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies? ForwardedCookies
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies?>();
            }

            /// <summary>forwarded_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_headers LightsailDistribution#forwarded_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedHeaders", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders\"}", isOptional: true)]
            public aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders? ForwardedHeaders
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders?>();
            }

            /// <summary>forwarded_query_strings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#forwarded_query_strings LightsailDistribution#forwarded_query_strings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedQueryStrings", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings\"}", isOptional: true)]
            public aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings? ForwardedQueryStrings
            {
                get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings?>();
            }

            /// <summary>The maximum amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the object has been updated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#maximum_ttl LightsailDistribution#maximum_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum amount of time that objects stay in the distribution's cache before the distribution forwards another request to the origin to determine whether the object has been updated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#minimum_ttl LightsailDistribution#minimum_ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumTtl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
