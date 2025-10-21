using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerPipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration")]
    public class SagemakerPipelineParallelismConfiguration : aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#max_parallel_execution_steps SagemakerPipeline#max_parallel_execution_steps}.</summary>
        [JsiiProperty(name: "maxParallelExecutionSteps", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxParallelExecutionSteps
        {
            get;
            set;
        }
    }
}
