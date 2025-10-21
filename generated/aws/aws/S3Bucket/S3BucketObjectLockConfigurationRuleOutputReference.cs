using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketObjectLockConfigurationRuleOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfigurationRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketObjectLockConfigurationRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketObjectLockConfigurationRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketObjectLockConfigurationRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketObjectLockConfigurationRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetention\"}}]")]
        public virtual void PutDefaultRetention(aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention)}, new object[]{@value});
        }

        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetentionOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetentionOutputReference DefaultRetention
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetentionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRetentionInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleDefaultRetention\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention? DefaultRetentionInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfigurationRuleDefaultRetention?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketObjectLockConfigurationRule? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfigurationRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
