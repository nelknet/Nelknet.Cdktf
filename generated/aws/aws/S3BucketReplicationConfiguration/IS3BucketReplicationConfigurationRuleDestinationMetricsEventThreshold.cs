using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold")]
    public interface IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#minutes S3BucketReplicationConfigurationA#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        double Minutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#minutes S3BucketReplicationConfigurationA#minutes}.</summary>
            [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
            public double Minutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
