using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketIntelligentTieringConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketIntelligentTieringConfiguration.S3BucketIntelligentTieringConfigurationTiering")]
    public class S3BucketIntelligentTieringConfigurationTiering : aws.S3BucketIntelligentTieringConfiguration.IS3BucketIntelligentTieringConfigurationTiering
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#access_tier S3BucketIntelligentTieringConfiguration#access_tier}.</summary>
        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessTier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_intelligent_tiering_configuration#days S3BucketIntelligentTieringConfiguration#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        public double Days
        {
            get;
            set;
        }
    }
}
