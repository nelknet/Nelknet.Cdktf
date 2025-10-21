using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilter")]
    public class S3BucketReplicationConfigurationRuleFilter : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilter
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#and S3BucketReplicationConfigurationA#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAnd\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterAnd? And
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#prefix S3BucketReplicationConfigurationA#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#tag S3BucketReplicationConfigurationA#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTag\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterTag? Tag
        {
            get;
            set;
        }
    }
}
