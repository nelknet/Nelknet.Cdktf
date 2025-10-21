using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    [JsiiInterface(nativeType: typeof(ISyntheticsCanaryArtifactConfig), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfig")]
    public interface ISyntheticsCanaryArtifactConfig
    {
        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
        /// </remarks>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISyntheticsCanaryArtifactConfig), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
            public aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
            {
                get => GetInstanceProperty<aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption?>();
            }
        }
    }
}
