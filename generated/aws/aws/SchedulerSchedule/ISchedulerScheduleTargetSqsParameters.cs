using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(ISchedulerScheduleTargetSqsParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters")]
    public interface ISchedulerScheduleTargetSqsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#message_group_id SchedulerSchedule#message_group_id}.</summary>
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchedulerScheduleTargetSqsParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters")]
        internal sealed class _Proxy : DeputyBase, aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#message_group_id SchedulerSchedule#message_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
