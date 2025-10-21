using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionCacheBehavior), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehavior")]
    public interface ILightsailDistributionCacheBehavior
    {
        /// <summary>The cache behavior for the specified path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
        /// </remarks>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        /// <summary>The path to a directory or file to cached, or not cache.</summary>
        /// <remarks>
        /// Use an asterisk symbol to specify wildcard directories (path/to/assets/<em>), and file types (</em>.html, *jpg, *js). Directories and file paths are case-sensitive.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#path LightsailDistribution#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionCacheBehavior), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The cache behavior for the specified path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#behavior LightsailDistribution#behavior}
            /// </remarks>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
