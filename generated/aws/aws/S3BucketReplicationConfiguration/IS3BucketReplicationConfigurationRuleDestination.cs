using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestination")]
    public interface IS3BucketReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#bucket S3BucketReplicationConfigurationA#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>access_control_translation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#access_control_translation S3BucketReplicationConfigurationA#access_control_translation}
        /// </remarks>
        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation? AccessControlTranslation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#account S3BucketReplicationConfigurationA#account}.</summary>
        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Account
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#encryption_configuration S3BucketReplicationConfigurationA#encryption_configuration}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration? EncryptionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#metrics S3BucketReplicationConfigurationA#metrics}
        /// </remarks>
        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetrics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetrics? Metrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>replication_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#replication_time S3BucketReplicationConfigurationA#replication_time}
        /// </remarks>
        [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTime? ReplicationTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#storage_class S3BucketReplicationConfigurationA#storage_class}.</summary>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageClass
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#bucket S3BucketReplicationConfigurationA#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access_control_translation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#access_control_translation S3BucketReplicationConfigurationA#access_control_translation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation\"}", isOptional: true)]
            public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation? AccessControlTranslation
            {
                get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#account S3BucketReplicationConfigurationA#account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Account
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#encryption_configuration S3BucketReplicationConfigurationA#encryption_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration\"}", isOptional: true)]
            public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration? EncryptionConfiguration
            {
                get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationEncryptionConfiguration?>();
            }

            /// <summary>metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#metrics S3BucketReplicationConfigurationA#metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationMetrics\"}", isOptional: true)]
            public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetrics? Metrics
            {
                get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationMetrics?>();
            }

            /// <summary>replication_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#replication_time S3BucketReplicationConfigurationA#replication_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleDestinationReplicationTime\"}", isOptional: true)]
            public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTime? ReplicationTime
            {
                get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleDestinationReplicationTime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#storage_class S3BucketReplicationConfigurationA#storage_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClass
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
