using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlBucketLifecycleConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleOutputReference), fullyQualifiedName: "aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3ControlBucketLifecycleConfigurationRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public S3ControlBucketLifecycleConfigurationRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlBucketLifecycleConfigurationRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlBucketLifecycleConfigurationRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAbortIncompleteMultipartUpload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}}]")]
        public virtual void PutAbortIncompleteMultipartUpload(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpiration\"}}]")]
        public virtual void PutExpiration(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilter\"}}]")]
        public virtual void PutFilter(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbortIncompleteMultipartUpload")]
        public virtual void ResetAbortIncompleteMultipartUpload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiration")]
        public virtual void ResetExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "abortIncompleteMultipartUpload", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference\"}")]
        public virtual aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference AbortIncompleteMultipartUpload
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUploadOutputReference>()!;
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpirationOutputReference\"}")]
        public virtual aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilterOutputReference\"}")]
        public virtual aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadInput", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true)]
        public virtual aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? AbortIncompleteMultipartUploadInput
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationInput", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleExpiration\"}", isOptional: true)]
        public virtual aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleExpiration? ExpirationInput
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRuleFilter\"}", isOptional: true)]
        public virtual aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleFilter? FilterInput
        {
            get => GetInstanceProperty<aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRuleFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3ControlBucketLifecycleConfiguration.IS3ControlBucketLifecycleConfigurationRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
