using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy")]
    public class PipesPipeTargetParametersBatchJobParametersRetryStrategy : aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#attempts PipesPipe#attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Attempts
        {
            get;
            set;
        }
    }
}
