using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersSagemakerPipelineParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters")]
    public interface IPipesPipeTargetParametersSagemakerPipelineParameters
    {
        /// <summary>pipeline_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#pipeline_parameter PipesPipe#pipeline_parameter}
        /// </remarks>
        [JsiiProperty(name: "pipelineParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PipelineParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersSagemakerPipelineParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pipeline_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#pipeline_parameter PipesPipe#pipeline_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PipelineParameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
