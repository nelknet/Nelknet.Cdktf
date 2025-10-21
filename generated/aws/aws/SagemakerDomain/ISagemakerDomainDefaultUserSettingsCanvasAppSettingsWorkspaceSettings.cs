using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings")]
    public interface ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_artifact_path SagemakerDomain#s3_artifact_path}.</summary>
        [JsiiProperty(name: "s3ArtifactPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ArtifactPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_kms_key_id SagemakerDomain#s3_kms_key_id}.</summary>
        [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KmsKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCanvasAppSettingsWorkspaceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_artifact_path SagemakerDomain#s3_artifact_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ArtifactPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ArtifactPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#s3_kms_key_id SagemakerDomain#s3_kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3KmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
