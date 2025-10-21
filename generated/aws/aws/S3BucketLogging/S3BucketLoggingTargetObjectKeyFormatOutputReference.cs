using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketLogging
{
    [JsiiClass(nativeType: typeof(aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatOutputReference), fullyQualifiedName: "aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketLoggingTargetObjectKeyFormatOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketLoggingTargetObjectKeyFormatOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketLoggingTargetObjectKeyFormatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketLoggingTargetObjectKeyFormatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPartitionedPrefix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}}]")]
        public virtual void PutPartitionedPrefix(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSimplePrefix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefix\"}}]")]
        public virtual void PutSimplePrefix(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPartitionedPrefix")]
        public virtual void ResetPartitionedPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSimplePrefix")]
        public virtual void ResetSimplePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "partitionedPrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference\"}")]
        public virtual aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference PartitionedPrefix
        {
            get => GetInstanceProperty<aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefixOutputReference>()!;
        }

        [JsiiProperty(name: "simplePrefix", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefixOutputReference\"}")]
        public virtual aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefixOutputReference SimplePrefix
        {
            get => GetInstanceProperty<aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefixOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionedPrefixInput", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatPartitionedPrefix\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix? PartitionedPrefixInput
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatPartitionedPrefix?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "simplePrefixInput", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormatSimplePrefix\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix? SimplePrefixInput
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormatSimplePrefix?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketLogging.S3BucketLoggingTargetObjectKeyFormat\"}", isOptional: true)]
        public virtual aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketLogging.IS3BucketLoggingTargetObjectKeyFormat?>();
            set => SetInstanceProperty(value);
        }
    }
}
