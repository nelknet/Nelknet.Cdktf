using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketObjectLockConfigurationOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketObjectLockConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketObjectLockConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketObjectLockConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketObjectLockConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketObjectLockConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}}]")]
        public virtual void PutRule(aws.S3Bucket.IS3BucketObjectLockConfigurationRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketObjectLockConfigurationRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetObjectLockEnabled")]
        public virtual void ResetObjectLockEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRuleOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketObjectLockConfigurationRuleOutputReference Rule
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketObjectLockConfigurationRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectLockEnabledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectLockEnabledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketObjectLockConfigurationRule? RuleInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfigurationRule?>();
        }

        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectLockEnabled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketObjectLockConfiguration\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketObjectLockConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketObjectLockConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
