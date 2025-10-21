using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(ISchedulerScheduleTarget), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTarget")]
    public interface ISchedulerScheduleTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#arn SchedulerSchedule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#role_arn SchedulerSchedule#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#dead_letter_config SchedulerSchedule#dead_letter_config}
        /// </remarks>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig? DeadLetterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#ecs_parameters SchedulerSchedule#ecs_parameters}
        /// </remarks>
        [JsiiProperty(name: "ecsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters? EcsParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>eventbridge_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#eventbridge_parameters SchedulerSchedule#eventbridge_parameters}
        /// </remarks>
        [JsiiProperty(name: "eventbridgeParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters? EventbridgeParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#input SchedulerSchedule#input}.</summary>
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#kinesis_parameters SchedulerSchedule#kinesis_parameters}
        /// </remarks>
        [JsiiProperty(name: "kinesisParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters? KinesisParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#retry_policy SchedulerSchedule#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>sagemaker_pipeline_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sagemaker_pipeline_parameters SchedulerSchedule#sagemaker_pipeline_parameters}
        /// </remarks>
        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters? SagemakerPipelineParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sqs_parameters SchedulerSchedule#sqs_parameters}
        /// </remarks>
        [JsiiProperty(name: "sqsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters? SqsParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchedulerScheduleTarget), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTarget")]
        internal sealed class _Proxy : DeputyBase, aws.SchedulerSchedule.ISchedulerScheduleTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#arn SchedulerSchedule#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#role_arn SchedulerSchedule#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dead_letter_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#dead_letter_config SchedulerSchedule#dead_letter_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig?>();
            }

            /// <summary>ecs_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#ecs_parameters SchedulerSchedule#ecs_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters? EcsParameters
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters?>();
            }

            /// <summary>eventbridge_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#eventbridge_parameters SchedulerSchedule#eventbridge_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventbridgeParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters? EventbridgeParameters
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#input SchedulerSchedule#input}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Input
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kinesis_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#kinesis_parameters SchedulerSchedule#kinesis_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters? KinesisParameters
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters?>();
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#retry_policy SchedulerSchedule#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicy\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy?>();
            }

            /// <summary>sagemaker_pipeline_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sagemaker_pipeline_parameters SchedulerSchedule#sagemaker_pipeline_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters? SagemakerPipelineParameters
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters?>();
            }

            /// <summary>sqs_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#sqs_parameters SchedulerSchedule#sqs_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters\"}", isOptional: true)]
            public aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters? SqsParameters
            {
                get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters?>();
            }
        }
    }
}
