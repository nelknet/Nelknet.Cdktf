using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketAcl
{
    [JsiiClass(nativeType: typeof(aws.S3BucketAcl.S3BucketAclAccessControlPolicyOutputReference), fullyQualifiedName: "aws.s3BucketAcl.S3BucketAclAccessControlPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketAclAccessControlPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketAclAccessControlPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketAclAccessControlPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketAclAccessControlPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrant(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketAcl.IS3BucketAclAccessControlPolicyGrant).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOwner", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwner\"}}]")]
        public virtual void PutOwner(aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrant")]
        public virtual void ResetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grant", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrantList\"}")]
        public virtual aws.S3BucketAcl.S3BucketAclAccessControlPolicyGrantList Grant
        {
            get => GetInstanceProperty<aws.S3BucketAcl.S3BucketAclAccessControlPolicyGrantList>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwnerOutputReference\"}")]
        public virtual aws.S3BucketAcl.S3BucketAclAccessControlPolicyOwnerOutputReference Owner
        {
            get => GetInstanceProperty<aws.S3BucketAcl.S3BucketAclAccessControlPolicyOwnerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GrantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicyOwner\"}", isOptional: true)]
        public virtual aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner? OwnerInput
        {
            get => GetInstanceProperty<aws.S3BucketAcl.IS3BucketAclAccessControlPolicyOwner?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketAcl.S3BucketAclAccessControlPolicy\"}", isOptional: true)]
        public virtual aws.S3BucketAcl.IS3BucketAclAccessControlPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketAcl.IS3BucketAclAccessControlPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
