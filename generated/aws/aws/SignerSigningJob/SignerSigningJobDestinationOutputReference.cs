using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningJob
{
    [JsiiClass(nativeType: typeof(aws.SignerSigningJob.SignerSigningJobDestinationOutputReference), fullyQualifiedName: "aws.signerSigningJob.SignerSigningJobDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SignerSigningJobDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SignerSigningJobDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SignerSigningJobDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SignerSigningJobDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestinationS3\"}}]")]
        public virtual void PutS3(aws.SignerSigningJob.ISignerSigningJobDestinationS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SignerSigningJob.ISignerSigningJobDestinationS3)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestinationS3OutputReference\"}")]
        public virtual aws.SignerSigningJob.SignerSigningJobDestinationS3OutputReference S3
        {
            get => GetInstanceProperty<aws.SignerSigningJob.SignerSigningJobDestinationS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestinationS3\"}", isOptional: true)]
        public virtual aws.SignerSigningJob.ISignerSigningJobDestinationS3? S3Input
        {
            get => GetInstanceProperty<aws.SignerSigningJob.ISignerSigningJobDestinationS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestination\"}", isOptional: true)]
        public virtual aws.SignerSigningJob.ISignerSigningJobDestination? InternalValue
        {
            get => GetInstanceProperty<aws.SignerSigningJob.ISignerSigningJobDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
