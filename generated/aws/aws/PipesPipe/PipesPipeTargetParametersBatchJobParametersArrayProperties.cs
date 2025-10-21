using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties")]
    public class PipesPipeTargetParametersBatchJobParametersArrayProperties : aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#size PipesPipe#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }
    }
}
