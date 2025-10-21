using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersKinesisStreamParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters")]
    public interface IPipesPipeTargetParametersKinesisStreamParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#partition_key PipesPipe#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
        string PartitionKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersKinesisStreamParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#partition_key PipesPipe#partition_key}.</summary>
            [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PartitionKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
