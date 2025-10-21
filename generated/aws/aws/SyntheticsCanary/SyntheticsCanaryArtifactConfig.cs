using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    [JsiiByValue(fqn: "aws.syntheticsCanary.SyntheticsCanaryArtifactConfig")]
    public class SyntheticsCanaryArtifactConfig : aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfig
    {
        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.syntheticsCanary.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
        public aws.SyntheticsCanary.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
        {
            get;
            set;
        }
    }
}
