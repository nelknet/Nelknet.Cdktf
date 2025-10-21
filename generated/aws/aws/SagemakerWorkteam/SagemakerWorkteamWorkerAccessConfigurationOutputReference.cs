using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiClass(nativeType: typeof(aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationOutputReference), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerWorkteamWorkerAccessConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerWorkteamWorkerAccessConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerWorkteamWorkerAccessConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkteamWorkerAccessConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Presign", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}}]")]
        public virtual void PutS3Presign(aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Presign")]
        public virtual void ResetS3Presign()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Presign", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference\"}")]
        public virtual aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference S3Presign
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3PresignOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3PresignInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign? S3PresignInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfiguration\"}", isOptional: true)]
        public virtual aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
