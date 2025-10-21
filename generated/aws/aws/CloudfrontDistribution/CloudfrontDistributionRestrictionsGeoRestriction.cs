using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction")]
    public class CloudfrontDistributionRestrictionsGeoRestriction : aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#restriction_type CloudfrontDistribution#restriction_type}.</summary>
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}")]
        public string RestrictionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#locations CloudfrontDistribution#locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Locations
        {
            get;
            set;
        }
    }
}
