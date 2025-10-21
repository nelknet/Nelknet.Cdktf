using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings")]
    public class SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_artifact_path SagemakerDomain#s3_artifact_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ArtifactPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ArtifactPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_kms_key_id SagemakerDomain#s3_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KmsKeyId
        {
            get;
            set;
        }
    }
}
