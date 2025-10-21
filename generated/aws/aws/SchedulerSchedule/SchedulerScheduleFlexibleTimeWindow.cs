using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleFlexibleTimeWindow")]
    public class SchedulerScheduleFlexibleTimeWindow : aws.SchedulerSchedule.ISchedulerScheduleFlexibleTimeWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#mode SchedulerSchedule#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#maximum_window_in_minutes SchedulerSchedule#maximum_window_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumWindowInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumWindowInMinutes
        {
            get;
            set;
        }
    }
}
