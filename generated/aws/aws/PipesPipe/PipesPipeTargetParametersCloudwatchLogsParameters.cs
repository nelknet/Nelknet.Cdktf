using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters")]
    public class PipesPipeTargetParametersCloudwatchLogsParameters : aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#log_stream_name PipesPipe#log_stream_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStreamName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStreamName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#timestamp PipesPipe#timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timestamp
        {
            get;
            set;
        }
    }
}
