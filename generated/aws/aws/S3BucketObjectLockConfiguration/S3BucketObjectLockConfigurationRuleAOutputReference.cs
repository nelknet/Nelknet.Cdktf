using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketObjectLockConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleAOutputReference), fullyQualifiedName: "aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketObjectLockConfigurationRuleAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketObjectLockConfigurationRuleAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketObjectLockConfigurationRuleAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketObjectLockConfigurationRuleAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA\"}}]")]
        public virtual void PutDefaultRetention(aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA)}, new object[]{@value});
        }

        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionAOutputReference\"}")]
        public virtual aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionAOutputReference DefaultRetention
        {
            get => GetInstanceProperty<aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionAOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRetentionInput", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleDefaultRetentionA\"}", isOptional: true)]
        public virtual aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA? DefaultRetentionInput
        {
            get => GetInstanceProperty<aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleDefaultRetentionA?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleA\"}", isOptional: true)]
        public virtual aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleA? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketObjectLockConfiguration.IS3BucketObjectLockConfigurationRuleA?>();
            set => SetInstanceProperty(value);
        }
    }
}
