using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiByValue(fqn: "aws.instance.InstanceInstanceMarketOptions")]
    public class InstanceInstanceMarketOptions : aws.Instance.IInstanceInstanceMarketOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#market_type Instance#market_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MarketType
        {
            get;
            set;
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#spot_options Instance#spot_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        public aws.Instance.IInstanceInstanceMarketOptionsSpotOptions? SpotOptions
        {
            get;
            set;
        }
    }
}
