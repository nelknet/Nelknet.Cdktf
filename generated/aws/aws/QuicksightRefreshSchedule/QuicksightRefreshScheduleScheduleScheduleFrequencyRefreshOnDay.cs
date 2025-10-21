using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightRefreshSchedule
{
    [JsiiByValue(fqn: "aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay")]
    public class QuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay : aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#day_of_month QuicksightRefreshSchedule#day_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#day_of_week QuicksightRefreshSchedule#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }
    }
}
