using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiByValue(fqn: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteria")]
    public class S3BucketReplicationConfigurationRuleSourceSelectionCriteria : aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria
    {
        /// <summary>replica_modifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#replica_modifications S3BucketReplicationConfigurationA#replica_modifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicaModifications", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications? ReplicaModifications
        {
            get;
            set;
        }

        /// <summary>sse_kms_encrypted_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_replication_configuration#sse_kms_encrypted_objects S3BucketReplicationConfigurationA#sse_kms_encrypted_objects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        public aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects
        {
            get;
            set;
        }
    }
}
