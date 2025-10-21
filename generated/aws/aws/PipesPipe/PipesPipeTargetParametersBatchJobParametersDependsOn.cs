using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn")]
    public class PipesPipeTargetParametersBatchJobParametersDependsOn : aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_id PipesPipe#job_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#type PipesPipe#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
