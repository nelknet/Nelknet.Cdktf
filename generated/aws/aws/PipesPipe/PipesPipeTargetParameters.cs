using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParameters")]
    public class PipesPipeTargetParameters : aws.PipesPipe.IPipesPipeTargetParameters
    {
        /// <summary>batch_job_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#batch_job_parameters PipesPipe#batch_job_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchJobParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters? BatchJobParameters
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cloudwatch_logs_parameters PipesPipe#cloudwatch_logs_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersCloudwatchLogsParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersCloudwatchLogsParameters? CloudwatchLogsParameters
        {
            get;
            set;
        }

        /// <summary>ecs_task_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ecs_task_parameters PipesPipe#ecs_task_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecsTaskParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParameters? EcsTaskParameters
        {
            get;
            set;
        }

        /// <summary>eventbridge_event_bus_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#eventbridge_event_bus_parameters PipesPipe#eventbridge_event_bus_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventbridgeEventBusParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEventbridgeEventBusParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersEventbridgeEventBusParameters? EventbridgeEventBusParameters
        {
            get;
            set;
        }

        /// <summary>http_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#http_parameters PipesPipe#http_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersHttpParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersHttpParameters? HttpParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#input_template PipesPipe#input_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputTemplate
        {
            get;
            set;
        }

        /// <summary>kinesis_stream_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#kinesis_stream_parameters PipesPipe#kinesis_stream_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersKinesisStreamParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersKinesisStreamParameters? KinesisStreamParameters
        {
            get;
            set;
        }

        /// <summary>lambda_function_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#lambda_function_parameters PipesPipe#lambda_function_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersLambdaFunctionParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersLambdaFunctionParameters? LambdaFunctionParameters
        {
            get;
            set;
        }

        /// <summary>redshift_data_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#redshift_data_parameters PipesPipe#redshift_data_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshiftDataParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersRedshiftDataParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersRedshiftDataParameters? RedshiftDataParameters
        {
            get;
            set;
        }

        /// <summary>sagemaker_pipeline_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sagemaker_pipeline_parameters PipesPipe#sagemaker_pipeline_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters? SagemakerPipelineParameters
        {
            get;
            set;
        }

        /// <summary>sqs_queue_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#sqs_queue_parameters PipesPipe#sqs_queue_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqsQueueParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSqsQueueParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersSqsQueueParameters? SqsQueueParameters
        {
            get;
            set;
        }

        /// <summary>step_function_state_machine_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#step_function_state_machine_parameters PipesPipe#step_function_state_machine_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionStateMachineParameters", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersStepFunctionStateMachineParameters\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersStepFunctionStateMachineParameters? StepFunctionStateMachineParameters
        {
            get;
            set;
        }
    }
}
