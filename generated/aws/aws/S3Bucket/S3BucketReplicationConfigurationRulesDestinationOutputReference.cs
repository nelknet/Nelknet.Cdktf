using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketReplicationConfigurationRulesDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketReplicationConfigurationRulesDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketReplicationConfigurationRulesDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRulesDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlTranslation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}}]")]
        public virtual void PutAccessControlTranslation(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationMetrics\"}}]")]
        public virtual void PutMetrics(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicationTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationReplicationTime\"}}]")]
        public virtual void PutReplicationTime(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationReplicationTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationReplicationTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlTranslation")]
        public virtual void ResetAccessControlTranslation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetrics")]
        public virtual void ResetMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaKmsKeyId")]
        public virtual void ResetReplicaKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationTime")]
        public virtual void ResetReplicationTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageClass")]
        public virtual void ResetStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlTranslation", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference AccessControlTranslation
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslationOutputReference>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationMetricsOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationMetricsOutputReference Metrics
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "replicationTime", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationReplicationTimeOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationReplicationTimeOutputReference ReplicationTime
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketReplicationConfigurationRulesDestinationReplicationTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlTranslationInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation? AccessControlTranslationInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationMetrics\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationMetrics? MetricsInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicaKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTimeInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestinationReplicationTime\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationReplicationTime? ReplicationTimeInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestinationReplicationTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketReplicationConfigurationRulesDestination\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketReplicationConfigurationRulesDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
