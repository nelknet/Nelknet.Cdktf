using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerPipeline
{
    [JsiiClass(nativeType: typeof(aws.SagemakerPipeline.SagemakerPipelineParallelismConfigurationOutputReference), fullyQualifiedName: "aws.sagemakerPipeline.SagemakerPipelineParallelismConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerPipelineParallelismConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerPipelineParallelismConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerPipelineParallelismConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerPipelineParallelismConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxParallelExecutionStepsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxParallelExecutionStepsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxParallelExecutionSteps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxParallelExecutionSteps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerPipeline.SagemakerPipelineParallelismConfiguration\"}", isOptional: true)]
        public virtual aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerPipeline.ISagemakerPipelineParallelismConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
