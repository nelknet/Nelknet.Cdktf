using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetKinesisParameters")]
    public class SchedulerScheduleTargetKinesisParameters : aws.SchedulerSchedule.ISchedulerScheduleTargetKinesisParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#partition_key SchedulerSchedule#partition_key}.</summary>
        [JsiiProperty(name: "partitionKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PartitionKey
        {
            get;
            set;
        }
    }
}
