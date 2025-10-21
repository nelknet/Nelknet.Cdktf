using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters")]
    public class PipesPipeSourceParametersSelfManagedKafkaParameters : aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#topic_name PipesPipe#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#additional_bootstrap_servers PipesPipe#additional_bootstrap_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalBootstrapServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalBootstrapServers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_size PipesPipe#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#consumer_group_id PipesPipe#consumer_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consumerGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerGroupId
        {
            get;
            set;
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#credentials PipesPipe#credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersCredentials\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersCredentials? Credentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_batching_window_in_seconds PipesPipe#maximum_batching_window_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumBatchingWindowInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#server_root_ca_certificate PipesPipe#server_root_ca_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverRootCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerRootCaCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position PipesPipe#starting_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingPosition
        {
            get;
            set;
        }

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#vpc PipesPipe#vpc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParametersVpc\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParametersVpc? Vpc
        {
            get;
            set;
        }
    }
}
