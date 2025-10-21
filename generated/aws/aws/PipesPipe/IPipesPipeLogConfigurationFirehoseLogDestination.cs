using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeLogConfigurationFirehoseLogDestination), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination")]
    public interface IPipesPipeLogConfigurationFirehoseLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#delivery_stream_arn PipesPipe#delivery_stream_arn}.</summary>
        [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string DeliveryStreamArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeLogConfigurationFirehoseLogDestination), fullyQualifiedName: "aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#delivery_stream_arn PipesPipe#delivery_stream_arn}.</summary>
            [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DeliveryStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
