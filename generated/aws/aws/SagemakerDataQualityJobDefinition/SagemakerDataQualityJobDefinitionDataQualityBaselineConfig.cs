using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    [JsiiByValue(fqn: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfig")]
    public class SagemakerDataQualityJobDefinitionDataQualityBaselineConfig : aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfig
    {
        /// <summary>constraints_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#constraints_resource SagemakerDataQualityJobDefinition#constraints_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "constraintsResource", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfigConstraintsResource\"}", isOptional: true)]
        public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfigConstraintsResource? ConstraintsResource
        {
            get;
            set;
        }

        /// <summary>statistics_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#statistics_resource SagemakerDataQualityJobDefinition#statistics_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statisticsResource", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionDataQualityBaselineConfigStatisticsResource\"}", isOptional: true)]
        public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionDataQualityBaselineConfigStatisticsResource? StatisticsResource
        {
            get;
            set;
        }
    }
}
