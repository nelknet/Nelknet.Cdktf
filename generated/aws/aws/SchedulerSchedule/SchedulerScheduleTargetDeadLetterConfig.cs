using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetDeadLetterConfig")]
    public class SchedulerScheduleTargetDeadLetterConfig : aws.SchedulerSchedule.ISchedulerScheduleTargetDeadLetterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#arn SchedulerSchedule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }
    }
}
