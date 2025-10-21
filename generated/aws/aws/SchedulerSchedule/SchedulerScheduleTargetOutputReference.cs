using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiClass(nativeType: typeof(aws.SchedulerSchedule.SchedulerScheduleTargetOutputReference), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SchedulerScheduleTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SchedulerScheduleTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchedulerScheduleTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchedulerScheduleTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters\"}}]")]
        public virtual void PutEcsParameters(aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventbridgeParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters\"}}]")]
        public virtual void PutEventbridgeParameters(aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters\"}}]")]
        public virtual void PutKinesisParameters(aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSagemakerPipelineParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}}]")]
        public virtual void PutSagemakerPipelineParameters(aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqsParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters\"}}]")]
        public virtual void PutSqsParameters(aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsParameters")]
        public virtual void ResetEcsParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventbridgeParameters")]
        public virtual void ResetEventbridgeParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInput")]
        public virtual void ResetInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisParameters")]
        public virtual void ResetKinesisParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSagemakerPipelineParameters")]
        public virtual void ResetSagemakerPipelineParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsParameters")]
        public virtual void ResetSqsParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfigOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetDeadLetterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "ecsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetEcsParametersOutputReference EcsParameters
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetEcsParametersOutputReference>()!;
        }

        [JsiiProperty(name: "eventbridgeParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParametersOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetEventbridgeParametersOutputReference EventbridgeParameters
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetEventbridgeParametersOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParametersOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetKinesisParametersOutputReference KinesisParameters
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetKinesisParametersOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicyOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "sagemakerPipelineParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersOutputReference SagemakerPipelineParameters
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersOutputReference>()!;
        }

        [JsiiProperty(name: "sqsParameters", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParametersOutputReference\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetSqsParametersOutputReference SqsParameters
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetSqsParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsParametersInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters? EcsParametersInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventbridgeParametersInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters? EventbridgeParametersInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisParametersInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters? KinesisParametersInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetRetryPolicy\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sagemakerPipelineParametersInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters? SagemakerPipelineParametersInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsParametersInput", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters? SqsParametersInput
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Input
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTarget\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTarget? InternalValue
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
