using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersPlacementConstraints")]
    public class SchedulerScheduleTargetEcsParametersPlacementConstraints : aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersPlacementConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#type SchedulerSchedule#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#expression SchedulerSchedule#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }
    }
}
