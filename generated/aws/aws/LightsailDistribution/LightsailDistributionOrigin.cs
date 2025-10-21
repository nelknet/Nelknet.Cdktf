using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lightsailDistribution.LightsailDistributionOrigin")]
    public class LightsailDistributionOrigin : aws.LightsailDistribution.ILightsailDistributionOrigin
    {
        /// <summary>The name of the origin resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#name LightsailDistribution#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The AWS Region name of the origin resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#region_name LightsailDistribution#region_name}
        /// </remarks>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }

        /// <summary>The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#protocol_policy LightsailDistribution#protocol_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocolPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtocolPolicy
        {
            get;
            set;
        }
    }
}
