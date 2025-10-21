using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesSourceSelectionCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSseKmsEncryptedObjects", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}}]")]
        public virtual void PutSseKmsEncryptedObjects(aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSseKmsEncryptedObjects")]
        public virtual void ResetSseKmsEncryptedObjects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference SseKmsEncryptedObjects
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjectsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseKmsEncryptedObjectsInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjectsInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
