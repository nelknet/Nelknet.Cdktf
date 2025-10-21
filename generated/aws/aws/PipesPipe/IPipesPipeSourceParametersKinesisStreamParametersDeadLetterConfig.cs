using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig")]
    public interface IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#arn PipesPipe#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#arn PipesPipe#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
