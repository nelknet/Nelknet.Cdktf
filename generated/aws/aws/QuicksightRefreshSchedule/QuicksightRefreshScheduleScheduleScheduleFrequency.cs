using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightRefreshSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequency")]
    public class QuicksightRefreshScheduleScheduleScheduleFrequency : aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequency
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#interval QuicksightRefreshSchedule#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        private object? _refreshOnDay;

        /// <summary>refresh_on_day block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#refresh_on_day QuicksightRefreshSchedule#refresh_on_day}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refreshOnDay", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RefreshOnDay
        {
            get => _refreshOnDay;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequencyRefreshOnDay).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _refreshOnDay = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#time_of_the_day QuicksightRefreshSchedule#time_of_the_day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeOfTheDay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeOfTheDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#timezone QuicksightRefreshSchedule#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }
    }
}
