using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(ISchedulerScheduleTargetSagemakerPipelineParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters")]
    public interface ISchedulerScheduleTargetSagemakerPipelineParameters
    {
        /// <summary>pipeline_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#pipeline_parameter SchedulerSchedule#pipeline_parameter}
        /// </remarks>
        [JsiiProperty(name: "pipelineParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PipelineParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchedulerScheduleTargetSagemakerPipelineParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters")]
        internal sealed class _Proxy : DeputyBase, aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pipeline_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#pipeline_parameter SchedulerSchedule#pipeline_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PipelineParameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
