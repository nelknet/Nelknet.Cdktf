using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters")]
    public class PipesPipeTargetParametersKinesisStreamParameters : aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#partition_key PipesPipe#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PartitionKey
        {
            get;
            set;
        }
    }
}
