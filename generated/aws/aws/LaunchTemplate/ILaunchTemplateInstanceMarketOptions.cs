using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateInstanceMarketOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceMarketOptions")]
    public interface ILaunchTemplateInstanceMarketOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#market_type LaunchTemplate#market_type}.</summary>
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MarketType
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#spot_options LaunchTemplate#spot_options}
        /// </remarks>
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateInstanceMarketOptions), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateInstanceMarketOptions")]
        internal sealed class _Proxy : DeputyBase, aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#market_type LaunchTemplate#market_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>spot_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#spot_options LaunchTemplate#spot_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
            public aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptions
            {
                get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions?>();
            }
        }
    }
}
