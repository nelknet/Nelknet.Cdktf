using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter")]
    public interface ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#name SchedulerSchedule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#value SchedulerSchedule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter")]
        internal sealed class _Proxy : DeputyBase, aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#name SchedulerSchedule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#value SchedulerSchedule#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
