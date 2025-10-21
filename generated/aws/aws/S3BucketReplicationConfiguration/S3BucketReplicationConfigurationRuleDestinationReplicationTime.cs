using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTime")]
    public class S3BucketReplicationConfigurationRuleDestinationReplicationTime : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#time S3BucketReplicationConfigurationA#time}
        /// </remarks>
        [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime\"}")]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime Time
        {
            get;
            set;
        }
    }
}
