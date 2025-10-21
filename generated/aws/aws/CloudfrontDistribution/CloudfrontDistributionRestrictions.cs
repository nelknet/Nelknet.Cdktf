using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionRestrictions")]
    public class CloudfrontDistributionRestrictions : aws.CloudfrontDistribution.ICloudfrontDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#geo_restriction CloudfrontDistribution#geo_restriction}
        /// </remarks>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionRestrictionsGeoRestriction\"}")]
        public aws.CloudfrontDistribution.ICloudfrontDistributionRestrictionsGeoRestriction GeoRestriction
        {
            get;
            set;
        }
    }
}
