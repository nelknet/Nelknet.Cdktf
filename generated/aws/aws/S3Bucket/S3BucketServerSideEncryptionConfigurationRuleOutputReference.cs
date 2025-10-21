using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketServerSideEncryptionConfigurationRuleOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketServerSideEncryptionConfigurationRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketServerSideEncryptionConfigurationRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketServerSideEncryptionConfigurationRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketServerSideEncryptionConfigurationRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplyServerSideEncryptionByDefault", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}}]")]
        public virtual void PutApplyServerSideEncryptionByDefault(aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketKeyEnabled")]
        public virtual void ResetBucketKeyEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference ApplyServerSideEncryptionByDefault
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefaultOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyServerSideEncryptionByDefaultInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefaultInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketKeyEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BucketKeyEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bucketKeyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BucketKeyEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketServerSideEncryptionConfigurationRule\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule? InternalValue
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketServerSideEncryptionConfigurationRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
