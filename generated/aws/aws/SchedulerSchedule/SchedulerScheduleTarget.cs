using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTarget")]
    public class SchedulerScheduleTarget : aws.SchedulerSchedule.ISchedulerScheduleTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#arn SchedulerSchedule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#role_arn SchedulerSchedule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#dead_letter_config SchedulerSchedule#dead_letter_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig? DeadLetterConfig
        {
            get;
            set;
        }

        /// <summary>ecs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#ecs_parameters SchedulerSchedule#ecs_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters? EcsParameters
        {
            get;
            set;
        }

        /// <summary>eventbridge_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#eventbridge_parameters SchedulerSchedule#eventbridge_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventbridgeParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters? EventbridgeParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#input SchedulerSchedule#input}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Input
        {
            get;
            set;
        }

        /// <summary>kinesis_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#kinesis_parameters SchedulerSchedule#kinesis_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters? KinesisParameters
        {
            get;
            set;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#retry_policy SchedulerSchedule#retry_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicy\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy? RetryPolicy
        {
            get;
            set;
        }

        /// <summary>sagemaker_pipeline_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sagemaker_pipeline_parameters SchedulerSchedule#sagemaker_pipeline_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters? SagemakerPipelineParameters
        {
            get;
            set;
        }

        /// <summary>sqs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sqs_parameters SchedulerSchedule#sqs_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters? SqsParameters
        {
            get;
            set;
        }
    }
}
