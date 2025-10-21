using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3Bucket
{
    [JsiiClass(nativeType: typeof(aws.S3Bucket.S3BucketLifecycleRuleOutputReference), fullyQualifiedName: "aws.s3Bucket.S3BucketLifecycleRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketLifecycleRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public S3BucketLifecycleRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected S3BucketLifecycleRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLifecycleRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleExpiration\"}}]")]
        public virtual void PutExpiration(aws.S3Bucket.IS3BucketLifecycleRuleExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketLifecycleRuleExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoncurrentVersionExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpiration\"}}]")]
        public virtual void PutNoncurrentVersionExpiration(aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoncurrentVersionTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoncurrentVersionTransition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionTransition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionTransition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionTransition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTransition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3Bucket.IS3BucketLifecycleRuleTransition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketLifecycleRuleTransition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketLifecycleRuleTransition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbortIncompleteMultipartUploadDays")]
        public virtual void ResetAbortIncompleteMultipartUploadDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiration")]
        public virtual void ResetExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoncurrentVersionExpiration")]
        public virtual void ResetNoncurrentVersionExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoncurrentVersionTransition")]
        public virtual void ResetNoncurrentVersionTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransition")]
        public virtual void ResetTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleExpirationOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketLifecycleRuleExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketLifecycleRuleExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpirationOutputReference\"}")]
        public virtual aws.S3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpirationOutputReference NoncurrentVersionExpiration
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionTransitionList\"}")]
        public virtual aws.S3Bucket.S3BucketLifecycleRuleNoncurrentVersionTransitionList NoncurrentVersionTransition
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketLifecycleRuleNoncurrentVersionTransitionList>()!;
        }

        [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleTransitionList\"}")]
        public virtual aws.S3Bucket.S3BucketLifecycleRuleTransitionList Transition
        {
            get => GetInstanceProperty<aws.S3Bucket.S3BucketLifecycleRuleTransitionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AbortIncompleteMultipartUploadDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleExpiration\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketLifecycleRuleExpiration? ExpirationInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketLifecycleRuleExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpirationInput", typeJson: "{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public virtual aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpirationInput
        {
            get => GetInstanceProperty<aws.S3Bucket.IS3BucketLifecycleRuleNoncurrentVersionExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionTransitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoncurrentVersionTransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AbortIncompleteMultipartUploadDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3Bucket.S3BucketLifecycleRule\"}]}}", isOptional: true)]
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
                        case aws.S3Bucket.IS3BucketLifecycleRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3Bucket.IS3BucketLifecycleRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
