using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings")]
    public interface ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings
    {
        /// <summary>Indicates whether the distribution forwards and caches based on query strings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
        /// </remarks>
        [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Option
        {
            get
            {
                return null;
            }
        }

        /// <summary>The specific query strings that the distribution forwards to the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#query_strings_allowed_list LightsailDistribution#query_strings_allowed_list}
        /// </remarks>
        [JsiiProperty(name: "queryStringsAllowedList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? QueryStringsAllowedList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates whether the distribution forwards and caches based on query strings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#option LightsailDistribution#option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Option
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The specific query strings that the distribution forwards to the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#query_strings_allowed_list LightsailDistribution#query_strings_allowed_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryStringsAllowedList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? QueryStringsAllowedList
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
