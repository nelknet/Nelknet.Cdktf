using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerPipeline
{
    [JsiiInterface(nativeType: typeof(ISagemakerPipelineParallelismConfiguration), fullyQualifiedName: "aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration")]
    public interface ISagemakerPipelineParallelismConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#max_parallel_execution_steps SagemakerPipeline#max_parallel_execution_steps}.</summary>
        [JsiiProperty(name: "maxParallelExecutionSteps", typeJson: "{\"primitive\":\"number\"}")]
        double MaxParallelExecutionSteps
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerPipelineParallelismConfiguration), fullyQualifiedName: "aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_pipeline#max_parallel_execution_steps SagemakerPipeline#max_parallel_execution_steps}.</summary>
            [JsiiProperty(name: "maxParallelExecutionSteps", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxParallelExecutionSteps
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
