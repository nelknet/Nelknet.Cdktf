using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerPipeline.SagemakerPipelinePipelineDefinitionS3Location")]
    public class SagemakerPipelinePipelineDefinitionS3Location : aws.SagemakerPipeline.ISagemakerPipelinePipelineDefinitionS3Location
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#bucket SagemakerPipeline#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#object_key SagemakerPipeline#object_key}.</summary>
        [JsiiProperty(name: "objectKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#version_id SagemakerPipeline#version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionId
        {
            get;
            set;
        }
    }
}
