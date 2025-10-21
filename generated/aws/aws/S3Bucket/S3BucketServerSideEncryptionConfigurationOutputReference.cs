using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketServerSideEncryptionConfigurationOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketServerSideEncryptionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketServerSideEncryptionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketServerSideEncryptionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketServerSideEncryptionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketServerSideEncryptionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}}]")]
        public virtual void PutRule(aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule)}, new object[]{@value});
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRuleOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketServerSideEncryptionConfigurationRuleOutputReference Rule
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketServerSideEncryptionConfigurationRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule? RuleInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketServerSideEncryptionConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketServerSideEncryptionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
