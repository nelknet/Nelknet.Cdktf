using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiClass(nativeType: typeof(aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionDateSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PartitionDateSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "partitionDateSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartitionDateSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix?>();
            set => SetInstanceProperty(value);
        }
    }
}
