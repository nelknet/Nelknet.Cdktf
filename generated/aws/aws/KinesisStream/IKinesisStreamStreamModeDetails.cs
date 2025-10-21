using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisStream
{
    [JsiiInterface(nativeType: typeof(IKinesisStreamStreamModeDetails), fullyQualifiedName: "aws.kinesisStream.KinesisStreamStreamModeDetails")]
    public interface IKinesisStreamStreamModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
        [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}")]
        string StreamMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisStreamStreamModeDetails), fullyQualifiedName: "aws.kinesisStream.KinesisStreamStreamModeDetails")]
        internal sealed class _Proxy : DeputyBase, aws.KinesisStream.IKinesisStreamStreamModeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
            [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
