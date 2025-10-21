using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    [JsiiClass(nativeType: typeof(aws.SyntheticsCanary.SyntheticsCanaryArtifactConfigOutputReference), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SyntheticsCanaryArtifactConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SyntheticsCanaryArtifactConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SyntheticsCanaryArtifactConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SyntheticsCanaryArtifactConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Encryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption\"}}]")]
        public virtual void PutS3Encryption(aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Encryption")]
        public virtual void ResetS3Encryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference\"}")]
        public virtual aws.SyntheticsCanary.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference S3Encryption
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.SyntheticsCanaryArtifactConfigS3EncryptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionInput", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption? S3EncryptionInput
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfig\"}", isOptional: true)]
        public virtual aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
