using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetSagemakerPipelineTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget")]
    public interface ICloudwatchEventTargetSagemakerPipelineTarget
    {
        /// <summary>pipeline_parameter_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#pipeline_parameter_list CloudwatchEventTarget#pipeline_parameter_list}
        /// </remarks>
        [JsiiProperty(name: "pipelineParameterList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PipelineParameterList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetSagemakerPipelineTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pipeline_parameter_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#pipeline_parameter_list CloudwatchEventTarget#pipeline_parameter_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineParameterList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PipelineParameterList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
