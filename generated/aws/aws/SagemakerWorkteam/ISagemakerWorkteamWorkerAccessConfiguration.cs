using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiInterface(nativeType: typeof(ISagemakerWorkteamWorkerAccessConfiguration), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfiguration")]
    public interface ISagemakerWorkteamWorkerAccessConfiguration
    {
        /// <summary>s3_presign block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#s3_presign SagemakerWorkteam#s3_presign}
        /// </remarks>
        [JsiiProperty(name: "s3Presign", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign? S3Presign
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkteamWorkerAccessConfiguration), fullyQualifiedName: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_presign block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#s3_presign SagemakerWorkteam#s3_presign}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Presign", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}", isOptional: true)]
            public aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign? S3Presign
            {
                get => GetInstanceProperty<aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign?>();
            }
        }
    }
}
