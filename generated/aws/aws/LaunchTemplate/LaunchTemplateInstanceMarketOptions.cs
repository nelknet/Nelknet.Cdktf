using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateInstanceMarketOptions")]
    public class LaunchTemplateInstanceMarketOptions : aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#market_type LaunchTemplate#market_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MarketType
        {
            get;
            set;
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#spot_options LaunchTemplate#spot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptionsSpotOptions? SpotOptions
        {
            get;
            set;
        }
    }
}
