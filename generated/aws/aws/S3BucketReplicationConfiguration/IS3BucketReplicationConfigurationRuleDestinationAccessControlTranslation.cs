using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation")]
    public interface IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#owner S3BucketReplicationConfigurationA#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#owner S3BucketReplicationConfigurationA#owner}.</summary>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
