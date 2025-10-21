using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParameters")]
    public interface IPipesPipeSourceParameters
    {
        /// <summary>activemq_broker_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#activemq_broker_parameters PipesPipe#activemq_broker_parameters}
        /// </remarks>
        [JsiiProperty(name: "activemqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters? ActivemqBrokerParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb_stream_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#dynamodb_stream_parameters PipesPipe#dynamodb_stream_parameters}
        /// </remarks>
        [JsiiProperty(name: "dynamodbStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters? DynamodbStreamParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#filter_criteria PipesPipe#filter_criteria}
        /// </remarks>
        [JsiiProperty(name: "filterCriteria", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersFilterCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria? FilterCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kinesis_stream_parameters PipesPipe#kinesis_stream_parameters}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters? KinesisStreamParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_streaming_kafka_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#managed_streaming_kafka_parameters PipesPipe#managed_streaming_kafka_parameters}
        /// </remarks>
        [JsiiProperty(name: "managedStreamingKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>rabbitmq_broker_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#rabbitmq_broker_parameters PipesPipe#rabbitmq_broker_parameters}
        /// </remarks>
        [JsiiProperty(name: "rabbitmqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_managed_kafka_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#self_managed_kafka_parameters PipesPipe#self_managed_kafka_parameters}
        /// </remarks>
        [JsiiProperty(name: "selfManagedKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_queue_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sqs_queue_parameters PipesPipe#sqs_queue_parameters}
        /// </remarks>
        [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSqsQueueParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters? SqsQueueParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>activemq_broker_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#activemq_broker_parameters PipesPipe#activemq_broker_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activemqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters? ActivemqBrokerParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParameters?>();
            }

            /// <summary>dynamodb_stream_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#dynamodb_stream_parameters PipesPipe#dynamodb_stream_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersDynamodbStreamParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters? DynamodbStreamParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersDynamodbStreamParameters?>();
            }

            /// <summary>filter_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#filter_criteria PipesPipe#filter_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterCriteria", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersFilterCriteria\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria? FilterCriteria
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersFilterCriteria?>();
            }

            /// <summary>kinesis_stream_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kinesis_stream_parameters PipesPipe#kinesis_stream_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters? KinesisStreamParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters?>();
            }

            /// <summary>managed_streaming_kafka_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#managed_streaming_kafka_parameters PipesPipe#managed_streaming_kafka_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedStreamingKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersManagedStreamingKafkaParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters? ManagedStreamingKafkaParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersManagedStreamingKafkaParameters?>();
            }

            /// <summary>rabbitmq_broker_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#rabbitmq_broker_parameters PipesPipe#rabbitmq_broker_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rabbitmqBrokerParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters? RabbitmqBrokerParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParameters?>();
            }

            /// <summary>self_managed_kafka_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#self_managed_kafka_parameters PipesPipe#self_managed_kafka_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfManagedKafkaParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSelfManagedKafkaParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters? SelfManagedKafkaParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSelfManagedKafkaParameters?>();
            }

            /// <summary>sqs_queue_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sqs_queue_parameters PipesPipe#sqs_queue_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersSqsQueueParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters? SqsQueueParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersSqsQueueParameters?>();
            }
        }
    }
}
