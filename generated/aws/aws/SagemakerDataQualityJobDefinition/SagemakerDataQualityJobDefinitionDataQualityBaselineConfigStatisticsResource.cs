using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    [JsiiByValue(fqn: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfigStatisticsResource")]
    public class SagemakerDataQualityJobDefinitionDataQualityBaselineConfigStatisticsResource : aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfigStatisticsResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#s3_uri SagemakerDataQualityJobDefinition#s3_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Uri
        {
            get;
            set;
        }
    }
}
