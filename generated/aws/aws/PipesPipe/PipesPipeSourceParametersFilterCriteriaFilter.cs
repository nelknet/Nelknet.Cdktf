using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeSourceParametersFilterCriteriaFilter")]
    public class PipesPipeSourceParametersFilterCriteriaFilter : aws.PipesPipe.IPipesPipeSourceParametersFilterCriteriaFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#pattern PipesPipe#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        public string Pattern
        {
            get;
            set;
        }
    }
}
