using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeEnrichmentParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeEnrichmentParameters")]
    public interface IPipesPipeEnrichmentParameters
    {
        /// <summary>http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
        /// </remarks>
        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters? HttpParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#input_template PipesPipe#input_template}.</summary>
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeEnrichmentParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeEnrichmentParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeEnrichmentParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeEnrichmentParametersHttpParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters? HttpParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeEnrichmentParametersHttpParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#input_template PipesPipe#input_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputTemplate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
