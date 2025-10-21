using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersManagedStreamingKafkaParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParametersCredentials")]
    public interface IPipesPipeSourceParametersManagedStreamingKafkaParametersCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#client_certificate_tls_auth PipesPipe#client_certificate_tls_auth}.</summary>
        [JsiiProperty(name: "clientCertificateTlsAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateTlsAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sasl_scram_512_auth PipesPipe#sasl_scram_512_auth}.</summary>
        [JsiiProperty(name: "saslScram512Auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslScram512Auth
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersManagedStreamingKafkaParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParametersCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParametersCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#client_certificate_tls_auth PipesPipe#client_certificate_tls_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateTlsAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateTlsAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sasl_scram_512_auth PipesPipe#sasl_scram_512_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslScram512Auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslScram512Auth
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
