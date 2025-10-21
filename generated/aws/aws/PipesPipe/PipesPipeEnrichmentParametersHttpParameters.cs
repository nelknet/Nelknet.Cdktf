using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters")]
    public class PipesPipeEnrichmentParametersHttpParameters : aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#header_parameters PipesPipe#header_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? HeaderParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#path_parameter_values PipesPipe#path_parameter_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pathParameterValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PathParameterValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#query_string_parameters PipesPipe#query_string_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryStringParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? QueryStringParameters
        {
            get;
            set;
        }
    }
}
