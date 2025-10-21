using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiClass(nativeType: typeof(aws.S3BucketLogging.S3BucketLoggingTargetGrantOutputReference), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetGrantOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketLoggingTargetGrantOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public S3BucketLoggingTargetGrantOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected S3BucketLoggingTargetGrantOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLoggingTargetGrantOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrantee", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGrantee\"}}]")]
        public virtual void PutGrantee(aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee)}, new object[]{@value});
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGranteeOutputReference\"}")]
        public virtual aws.S3BucketLogging.S3BucketLoggingTargetGrantGranteeOutputReference Grantee
        {
            get => GetInstanceProperty<aws.S3BucketLogging.S3BucketLoggingTargetGrantGranteeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "granteeInput", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrantGrantee\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee? GranteeInput
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetGrantGrantee?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PermissionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Permission
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetGrant\"}]}}", isOptional: true)]
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
                        case aws.S3BucketLogging.IS3BucketLoggingTargetGrant cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketLogging.IS3BucketLoggingTargetGrant).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
