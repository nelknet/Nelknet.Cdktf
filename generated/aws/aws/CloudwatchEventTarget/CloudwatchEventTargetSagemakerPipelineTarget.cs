using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiByValue(fqn: "aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget")]
    public class CloudwatchEventTargetSagemakerPipelineTarget : aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget
    {
        private object? _pipelineParameterList;

        /// <summary>pipeline_parameter_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#pipeline_parameter_list CloudwatchEventTarget#pipeline_parameter_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineParameterList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PipelineParameterList
        {
            get => _pipelineParameterList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pipelineParameterList = value;
            }
        }
    }
}
