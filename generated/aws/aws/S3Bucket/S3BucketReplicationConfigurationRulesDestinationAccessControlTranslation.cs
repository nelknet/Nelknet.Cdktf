using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
    public class S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation : aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#owner S3Bucket#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public string Owner
        {
            get;
            set;
        }
    }
}
