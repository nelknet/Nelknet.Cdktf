using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeLogConfigurationFirehoseLogDestination")]
    public class PipesPipeLogConfigurationFirehoseLogDestination : aws.PipesPipe.IPipesPipeLogConfigurationFirehoseLogDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#delivery_stream_arn PipesPipe#delivery_stream_arn}.</summary>
        [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DeliveryStreamArn
        {
            get;
            set;
        }
    }
}
