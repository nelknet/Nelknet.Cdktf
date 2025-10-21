using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig")]
    public class PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig : aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#arn PipesPipe#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}
