using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionDefaultCacheBehavior")]
    public interface ILightsailDistributionDefaultCacheBehavior
    {
        /// <summary>The cache behavior of the distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
        /// </remarks>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionDefaultCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionDefaultCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The cache behavior of the distribution.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
            /// </remarks>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
