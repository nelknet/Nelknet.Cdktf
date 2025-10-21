using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersSelfManagedKafkaParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters")]
    public interface IPipesPipeSourceParametersSelfManagedKafkaParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#topic_name PipesPipe#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        string TopicName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#additional_bootstrap_servers PipesPipe#additional_bootstrap_servers}.</summary>
        [JsiiProperty(name: "additionalBootstrapServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalBootstrapServers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_size PipesPipe#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#consumer_group_id PipesPipe#consumer_group_id}.</summary>
        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#credentials PipesPipe#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_batching_window_in_seconds PipesPipe#maximum_batching_window_in_seconds}.</summary>
        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBatchingWindowInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#server_root_ca_certificate PipesPipe#server_root_ca_certificate}.</summary>
        [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerRootCaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position PipesPipe#starting_position}.</summary>
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#vpc PipesPipe#vpc}
        /// </remarks>
        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpc\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc? Vpc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersSelfManagedKafkaParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#topic_name PipesPipe#topic_name}.</summary>
            [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#additional_bootstrap_servers PipesPipe#additional_bootstrap_servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalBootstrapServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalBootstrapServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_size PipesPipe#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#consumer_group_id PipesPipe#consumer_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#credentials PipesPipe#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials? Credentials
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_batching_window_in_seconds PipesPipe#maximum_batching_window_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBatchingWindowInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#server_root_ca_certificate PipesPipe#server_root_ca_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerRootCaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position PipesPipe#starting_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingPosition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#vpc PipesPipe#vpc}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpc\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc? Vpc
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc?>();
            }
        }
    }
}
