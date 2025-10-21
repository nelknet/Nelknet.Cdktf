using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersKinesisStreamParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters")]
    public interface IPipesPipeSourceParametersKinesisStreamParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position PipesPipe#starting_position}.</summary>
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
        string StartingPosition
        {
            get;
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

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#dead_letter_config PipesPipe#dead_letter_config}
        /// </remarks>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_record_age_in_seconds PipesPipe#maximum_record_age_in_seconds}.</summary>
        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumRecordAgeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_retry_attempts PipesPipe#maximum_retry_attempts}.</summary>
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumRetryAttempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#on_partial_batch_item_failure PipesPipe#on_partial_batch_item_failure}.</summary>
        [JsiiProperty(name: "onPartialBatchItemFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnPartialBatchItemFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#parallelization_factor PipesPipe#parallelization_factor}.</summary>
        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParallelizationFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position_timestamp PipesPipe#starting_position_timestamp}.</summary>
        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingPositionTimestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersKinesisStreamParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position PipesPipe#starting_position}.</summary>
            [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
            public string StartingPosition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_size PipesPipe#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>dead_letter_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#dead_letter_config PipesPipe#dead_letter_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeSourceParametersKinesisStreamParametersDeadLetterConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_batching_window_in_seconds PipesPipe#maximum_batching_window_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBatchingWindowInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_record_age_in_seconds PipesPipe#maximum_record_age_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumRecordAgeInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#maximum_retry_attempts PipesPipe#maximum_retry_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumRetryAttempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#on_partial_batch_item_failure PipesPipe#on_partial_batch_item_failure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onPartialBatchItemFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnPartialBatchItemFailure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#parallelization_factor PipesPipe#parallelization_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParallelizationFactor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#starting_position_timestamp PipesPipe#starting_position_timestamp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingPositionTimestamp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
