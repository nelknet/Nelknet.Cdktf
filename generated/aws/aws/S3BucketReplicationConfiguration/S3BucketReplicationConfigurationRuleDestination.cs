using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestination")]
    public class S3BucketReplicationConfigurationRuleDestination : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#bucket S3BucketReplicationConfigurationA#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>access_control_translation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#access_control_translation S3BucketReplicationConfigurationA#access_control_translation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation? AccessControlTranslation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#account S3BucketReplicationConfigurationA#account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Account
        {
            get;
            set;
        }

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#encryption_configuration S3BucketReplicationConfigurationA#encryption_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration? EncryptionConfiguration
        {
            get;
            set;
        }

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#metrics S3BucketReplicationConfigurationA#metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetrics\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetrics? Metrics
        {
            get;
            set;
        }

        /// <summary>replication_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#replication_time S3BucketReplicationConfigurationA#replication_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTime\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTime? ReplicationTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#storage_class S3BucketReplicationConfigurationA#storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageClass
        {
            get;
            set;
        }
    }
}
