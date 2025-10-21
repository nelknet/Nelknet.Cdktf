using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersSqsQueueParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters")]
    public interface IPipesPipeTargetParametersSqsQueueParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_deduplication_id PipesPipe#message_deduplication_id}.</summary>
        [JsiiProperty(name: "messageDeduplicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageDeduplicationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_group_id PipesPipe#message_group_id}.</summary>
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersSqsQueueParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_deduplication_id PipesPipe#message_deduplication_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageDeduplicationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageDeduplicationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#message_group_id PipesPipe#message_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
