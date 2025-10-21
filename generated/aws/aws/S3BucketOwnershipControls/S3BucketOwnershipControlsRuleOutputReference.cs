using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketOwnershipControls
{
    [JsiiClass(nativeType: typeof(aws.S3BucketOwnershipControls.S3BucketOwnershipControlsRuleOutputReference), fullyQualifiedName: "aws.s3BucketOwnershipControls.S3BucketOwnershipControlsRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketOwnershipControlsRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketOwnershipControlsRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketOwnershipControlsRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketOwnershipControlsRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectOwnershipInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectOwnershipInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectOwnership
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketOwnershipControls.S3BucketOwnershipControlsRule\"}", isOptional: true)]
        public virtual aws.S3BucketOwnershipControls.IS3BucketOwnershipControlsRule? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketOwnershipControls.IS3BucketOwnershipControlsRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
