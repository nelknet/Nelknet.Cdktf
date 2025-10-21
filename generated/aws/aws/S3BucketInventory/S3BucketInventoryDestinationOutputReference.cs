using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketInventory
{
    [JsiiClass(nativeType: typeof(aws.S3BucketInventory.S3BucketInventoryDestinationOutputReference), fullyQualifiedName: "aws.s3BucketInventory.S3BucketInventoryDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketInventoryDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketInventoryDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketInventoryDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventoryDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucket\"}}]")]
        public virtual void PutBucket(aws.S3BucketInventory.IS3BucketInventoryDestinationBucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketInventory.IS3BucketInventoryDestinationBucket)}, new object[]{@value});
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucketOutputReference\"}")]
        public virtual aws.S3BucketInventory.S3BucketInventoryDestinationBucketOutputReference Bucket
        {
            get => GetInstanceProperty<aws.S3BucketInventory.S3BucketInventoryDestinationBucketOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestinationBucket\"}", isOptional: true)]
        public virtual aws.S3BucketInventory.IS3BucketInventoryDestinationBucket? BucketInput
        {
            get => GetInstanceProperty<aws.S3BucketInventory.IS3BucketInventoryDestinationBucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketInventory.S3BucketInventoryDestination\"}", isOptional: true)]
        public virtual aws.S3BucketInventory.IS3BucketInventoryDestination? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketInventory.IS3BucketInventoryDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
