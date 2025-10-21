using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobOutputConfig")]
    public class SagemakerDataQualityJobDefinitionDataQualityJobOutputConfig : aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobOutputConfig
    {
        /// <summary>monitoring_outputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#monitoring_outputs SagemakerDataQualityJobDefinition#monitoring_outputs}
        /// </remarks>
        [JsiiProperty(name: "monitoringOutputs", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityJobOutputConfigMonitoringOutputs\"}")]
        public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityJobOutputConfigMonitoringOutputs MonitoringOutputs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#kms_key_id SagemakerDataQualityJobDefinition#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }
    }
}
