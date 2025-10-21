using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters")]
    public class PipesPipeTargetParametersLambdaFunctionParameters : aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#invocation_type PipesPipe#invocation_type}.</summary>
        [JsiiProperty(name: "invocationType", typeJson: "{\"primitive\":\"string\"}")]
        public string InvocationType
        {
            get;
            set;
        }
    }
}
