using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime")]
    public interface IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#minutes S3BucketReplicationConfigurationA#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        double Minutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime
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
