using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources")]
    public class SagemakerDataQualityJobDefinitionJobResources : aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResources
    {
        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#cluster_config SagemakerDataQualityJobDefinition#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResourcesClusterConfig\"}")]
        public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResourcesClusterConfig ClusterConfig
        {
            get;
            set;
        }
    }
}
