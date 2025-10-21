using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ObjectCopy
{
    [JsiiClass(nativeType: typeof(aws.S3ObjectCopy.S3ObjectCopyOverrideProviderOutputReference), fullyQualifiedName: "aws.s3ObjectCopy.S3ObjectCopyOverrideProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ObjectCopyOverrideProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ObjectCopyOverrideProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3ObjectCopyOverrideProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ObjectCopyOverrideProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags\"}}]")]
        public virtual void PutDefaultTags(aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultTags")]
        public virtual void ResetDefaultTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultTags", typeJson: "{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTagsOutputReference\"}")]
        public virtual aws.S3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTagsOutputReference DefaultTags
        {
            get => GetInstanceProperty<aws.S3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTagsInput", typeJson: "{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProviderDefaultTags\"}", isOptional: true)]
        public virtual aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags? DefaultTagsInput
        {
            get => GetInstanceProperty<aws.S3ObjectCopy.IS3ObjectCopyOverrideProviderDefaultTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ObjectCopy.S3ObjectCopyOverrideProvider\"}", isOptional: true)]
        public virtual aws.S3ObjectCopy.IS3ObjectCopyOverrideProvider? InternalValue
        {
            get => GetInstanceProperty<aws.S3ObjectCopy.IS3ObjectCopyOverrideProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
