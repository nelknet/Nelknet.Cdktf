using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(ISchedulerScheduleTargetKinesisParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters")]
    public interface ISchedulerScheduleTargetKinesisParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#partition_key SchedulerSchedule#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
        string PartitionKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISchedulerScheduleTargetKinesisParameters), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters")]
        internal sealed class _Proxy : DeputyBase, aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#partition_key SchedulerSchedule#partition_key}.</summary>
            [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PartitionKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
