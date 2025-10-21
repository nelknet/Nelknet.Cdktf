using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleSourceSelectionCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReplicaModifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}}]")]
        public virtual void PutReplicaModifications(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseKmsEncryptedObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}}]")]
        public virtual void PutSseKmsEncryptedObjects(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetReplicaModifications")]
        public virtual void ResetReplicaModifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSseKmsEncryptedObjects")]
        public virtual void ResetSseKmsEncryptedObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "replicaModifications", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference\"}")]
        public virtual aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference ReplicaModifications
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModificationsOutputReference>()!;
        }

        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference\"}")]
        public virtual aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference SseKmsEncryptedObjects
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaModificationsInput", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications? ReplicaModificationsInput
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaReplicaModifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjectsInput", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjectsInput
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleSourceSelectionCriteria\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
