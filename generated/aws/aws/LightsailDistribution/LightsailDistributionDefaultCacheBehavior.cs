using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailDistribution.LightsailDistributionDefaultCacheBehavior")]
    public class LightsailDistributionDefaultCacheBehavior : aws.LightsailDistribution.ILightsailDistributionDefaultCacheBehavior
    {
        /// <summary>The cache behavior of the distribution.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
        /// </remarks>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public string Behavior
        {
            get;
            set;
        }
    }
}
