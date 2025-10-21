using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParameters")]
    public interface IPipesPipeTargetParameters
    {
        /// <summary>batch_job_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_job_parameters PipesPipe#batch_job_parameters}
        /// </remarks>
        [JsiiProperty(name: "batchJobParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters? BatchJobParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_logs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_parameters PipesPipe#cloudwatch_logs_parameters}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogsParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_task_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ecs_task_parameters PipesPipe#ecs_task_parameters}
        /// </remarks>
        [JsiiProperty(name: "ecsTaskParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters? EcsTaskParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>eventbridge_event_bus_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#eventbridge_event_bus_parameters PipesPipe#eventbridge_event_bus_parameters}
        /// </remarks>
        [JsiiProperty(name: "eventbridgeEventBusParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
        /// </remarks>
        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersHttpParameters? HttpParameters
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

        /// <summary>kinesis_stream_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kinesis_stream_parameters PipesPipe#kinesis_stream_parameters}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters? KinesisStreamParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#lambda_function_parameters PipesPipe#lambda_function_parameters}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters? LambdaFunctionParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_data_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#redshift_data_parameters PipesPipe#redshift_data_parameters}
        /// </remarks>
        [JsiiProperty(name: "redshiftDataParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters? RedshiftDataParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>sagemaker_pipeline_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sagemaker_pipeline_parameters PipesPipe#sagemaker_pipeline_parameters}
        /// </remarks>
        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters
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
        [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters? SqsQueueParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_function_state_machine_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#step_function_state_machine_parameters PipesPipe#step_function_state_machine_parameters}
        /// </remarks>
        [JsiiProperty(name: "stepFunctionStateMachineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>batch_job_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_job_parameters PipesPipe#batch_job_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchJobParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters? BatchJobParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters?>();
            }

            /// <summary>cloudwatch_logs_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_parameters PipesPipe#cloudwatch_logs_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogsParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters?>();
            }

            /// <summary>ecs_task_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ecs_task_parameters PipesPipe#ecs_task_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsTaskParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters? EcsTaskParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters?>();
            }

            /// <summary>eventbridge_event_bus_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#eventbridge_event_bus_parameters PipesPipe#eventbridge_event_bus_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventbridgeEventBusParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters?>();
            }

            /// <summary>http_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersHttpParameters? HttpParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersHttpParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#input_template PipesPipe#input_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputTemplate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kinesis_stream_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kinesis_stream_parameters PipesPipe#kinesis_stream_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters? KinesisStreamParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters?>();
            }

            /// <summary>lambda_function_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#lambda_function_parameters PipesPipe#lambda_function_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters? LambdaFunctionParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters?>();
            }

            /// <summary>redshift_data_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#redshift_data_parameters PipesPipe#redshift_data_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftDataParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters? RedshiftDataParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters?>();
            }

            /// <summary>sagemaker_pipeline_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sagemaker_pipeline_parameters PipesPipe#sagemaker_pipeline_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters?>();
            }

            /// <summary>sqs_queue_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sqs_queue_parameters PipesPipe#sqs_queue_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters? SqsQueueParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters?>();
            }

            /// <summary>step_function_state_machine_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#step_function_state_machine_parameters PipesPipe#step_function_state_machine_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctionStateMachineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParameters\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters?>();
            }
        }
    }
}
