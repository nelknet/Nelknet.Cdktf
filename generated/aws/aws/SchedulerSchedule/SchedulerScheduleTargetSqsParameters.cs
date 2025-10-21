using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetSqsParameters")]
    public class SchedulerScheduleTargetSqsParameters : aws.SchedulerSchedule.ISchedulerScheduleTargetSqsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#message_group_id SchedulerSchedule#message_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageGroupId
        {
            get;
            set;
        }
    }
}
