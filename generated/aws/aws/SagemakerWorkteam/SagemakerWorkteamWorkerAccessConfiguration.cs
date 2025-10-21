using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfiguration")]
    public class SagemakerWorkteamWorkerAccessConfiguration : aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfiguration
    {
        /// <summary>s3_presign block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#s3_presign SagemakerWorkteam#s3_presign}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Presign", typeJson: "{\"fqn\":\"aws.sagemakerWorkteam.SagemakerWorkteamWorkerAccessConfigurationS3Presign\"}", isOptional: true)]
        public aws.SagemakerWorkteam.ISagemakerWorkteamWorkerAccessConfigurationS3Presign? S3Presign
        {
            get;
            set;
        }
    }
}
