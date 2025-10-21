using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetrics")]
    public class S3BucketReplicationConfigurationRuleDestinationMetrics : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetrics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>event_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#event_threshold S3BucketReplicationConfigurationA#event_threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventThreshold", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold? EventThreshold
        {
            get;
            set;
        }
    }
}
