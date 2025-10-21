using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHub
{
    [JsiiByValue(fqn: "aws.sagemakerHub.SagemakerHubS3StorageConfig")]
    public class SagemakerHubS3StorageConfig : aws.SagemakerHub.ISagemakerHubS3StorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#s3_output_path SagemakerHub#s3_output_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3OutputPath
        {
            get;
            set;
        }
    }
}
