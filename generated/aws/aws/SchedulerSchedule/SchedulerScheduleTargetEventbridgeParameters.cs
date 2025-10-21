using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetEventbridgeParameters")]
    public class SchedulerScheduleTargetEventbridgeParameters : aws.SchedulerSchedule.ISchedulerScheduleTargetEventbridgeParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#detail_type SchedulerSchedule#detail_type}.</summary>
        [JsiiProperty(name: "detailType", typeJson: "{\"primitive\":\"string\"}")]
        public string DetailType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#source SchedulerSchedule#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }
    }
}
