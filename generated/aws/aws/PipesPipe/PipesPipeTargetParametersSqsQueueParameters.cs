using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters")]
    public class PipesPipeTargetParametersSqsQueueParameters : aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_deduplication_id PipesPipe#message_deduplication_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageDeduplicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageDeduplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_group_id PipesPipe#message_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageGroupId
        {
            get;
            set;
        }
    }
}
