using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters")]
    public class PipesPipeTargetParametersEventbridgeEventBusParameters : aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#detail_type PipesPipe#detail_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detailType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DetailType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#endpoint_id PipesPipe#endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#resources PipesPipe#resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Resources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#source PipesPipe#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#time PipesPipe#time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Time
        {
            get;
            set;
        }
    }
}
