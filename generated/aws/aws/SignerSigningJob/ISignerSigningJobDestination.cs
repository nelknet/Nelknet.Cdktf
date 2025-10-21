using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SignerSigningJob
{
    [JsiiInterface(nativeType: typeof(ISignerSigningJobDestination), fullyQualifiedName: "aws.signerSigningJob.SignerSigningJobDestination")]
    public interface ISignerSigningJobDestination
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#s3 SignerSigningJob#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestinationS3\"}")]
        aws.SignerSigningJob.ISignerSigningJobDestinationS3 S3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISignerSigningJobDestination), fullyQualifiedName: "aws.signerSigningJob.SignerSigningJobDestination")]
        internal sealed class _Proxy : DeputyBase, aws.SignerSigningJob.ISignerSigningJobDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_job#s3 SignerSigningJob#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signerSigningJob.SignerSigningJobDestinationS3\"}")]
            public aws.SignerSigningJob.ISignerSigningJobDestinationS3 S3
            {
                get => GetInstanceProperty<aws.SignerSigningJob.ISignerSigningJobDestinationS3>()!;
            }
        }
    }
}
