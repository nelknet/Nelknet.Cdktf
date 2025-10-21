using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHub
{
    [JsiiInterface(nativeType: typeof(ISagemakerHubS3StorageConfig), fullyQualifiedName: "aws.sagemakerHub.SagemakerHubS3StorageConfig")]
    public interface ISagemakerHubS3StorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#s3_output_path SagemakerHub#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3OutputPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHubS3StorageConfig), fullyQualifiedName: "aws.sagemakerHub.SagemakerHubS3StorageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHub.ISagemakerHubS3StorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#s3_output_path SagemakerHub#s3_output_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3OutputPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
