using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials")]
    public interface IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#basic_auth PipesPipe#basic_auth}.</summary>
        [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BasicAuth
        {
            get
            {
                return null;
            }
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sasl_scram_256_auth PipesPipe#sasl_scram_256_auth}.</summary>
        [JsiiProperty(name: "saslScram256Auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslScram256Auth
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

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#basic_auth PipesPipe#basic_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BasicAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#client_certificate_tls_auth PipesPipe#client_certificate_tls_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateTlsAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateTlsAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sasl_scram_256_auth PipesPipe#sasl_scram_256_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslScram256Auth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslScram256Auth
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
