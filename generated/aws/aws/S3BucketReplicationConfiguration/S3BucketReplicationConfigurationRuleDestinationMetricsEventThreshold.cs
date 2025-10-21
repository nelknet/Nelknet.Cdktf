using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold")]
    public class S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#minutes S3BucketReplicationConfigurationA#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        public double Minutes
        {
            get;
            set;
        }
    }
}
