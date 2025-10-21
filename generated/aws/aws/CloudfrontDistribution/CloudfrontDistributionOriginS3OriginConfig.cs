using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionOriginS3OriginConfig")]
    public class CloudfrontDistributionOriginS3OriginConfig : aws.CloudfrontDistribution.ICloudfrontDistributionOriginS3OriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_access_identity CloudfrontDistribution#origin_access_identity}.</summary>
        [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginAccessIdentity
        {
            get;
            set;
        }
    }
}
