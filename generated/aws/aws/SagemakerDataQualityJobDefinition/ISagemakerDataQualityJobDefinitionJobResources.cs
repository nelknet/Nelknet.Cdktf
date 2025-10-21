using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDataQualityJobDefinition
{
    [JsiiInterface(nativeType: typeof(ISagemakerDataQualityJobDefinitionJobResources), fullyQualifiedName: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources")]
    public interface ISagemakerDataQualityJobDefinitionJobResources
    {
        /// <summary>cluster_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#cluster_config SagemakerDataQualityJobDefinition#cluster_config}
        /// </remarks>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResourcesClusterConfig\"}")]
        aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResourcesClusterConfig ClusterConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDataQualityJobDefinitionJobResources), fullyQualifiedName: "aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResources")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cluster_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_data_quality_job_definition#cluster_config SagemakerDataQualityJobDefinition#cluster_config}
            /// </remarks>
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"fqn\":\"aws.sagemakerDataQualityJobDefinition.SagemakerDataQualityJobDefinitionJobResourcesClusterConfig\"}")]
            public aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResourcesClusterConfig ClusterConfig
            {
                get => GetInstanceProperty<aws.SagemakerDataQualityJobDefinition.ISagemakerDataQualityJobDefinitionJobResourcesClusterConfig>()!;
            }
        }
    }
}
