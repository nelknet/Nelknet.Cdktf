using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisStream
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisStream.KinesisStreamStreamModeDetails")]
    public class KinesisStreamStreamModeDetails : aws.KinesisStream.IKinesisStreamStreamModeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_stream#stream_mode KinesisStream#stream_mode}.</summary>
        [JsiiProperty(name: "streamMode", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamMode
        {
            get;
            set;
        }
    }
}
