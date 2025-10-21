using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeEnrichmentParameters")]
    public class PipesPipeEnrichmentParameters : aws.PipesPipe.IPipesPipeEnrichmentParameters
    {
        /// <summary>http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters? HttpParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#input_template PipesPipe#input_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputTemplate
        {
            get;
            set;
        }
    }
}
