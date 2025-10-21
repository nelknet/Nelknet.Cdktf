using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailDistribution.LightsailDistributionCacheBehavior")]
    public class LightsailDistributionCacheBehavior : aws.LightsailDistribution.ILightsailDistributionCacheBehavior
    {
        /// <summary>The cache behavior for the specified path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
        /// </remarks>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public string Behavior
        {
            get;
            set;
        }

        /// <summary>The path to a directory or file to cached, or not cache.</summary>
        /// <remarks>
        /// Use an asterisk symbol to specify wildcard directories (path/to/assets/<em>), and file types (</em>.html, *jpg, *js). Directories and file paths are case-sensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#path LightsailDistribution#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}
