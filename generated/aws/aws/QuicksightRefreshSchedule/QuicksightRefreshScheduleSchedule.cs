using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightRefreshSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightRefreshSchedule.QuicksightRefreshScheduleSchedule")]
    public class QuicksightRefreshScheduleSchedule : aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#refresh_type QuicksightRefreshSchedule#refresh_type}.</summary>
        [JsiiProperty(name: "refreshType", typeJson: "{\"primitive\":\"string\"}")]
        public string RefreshType
        {
            get;
            set;
        }

        private object? _scheduleFrequency;

        /// <summary>schedule_frequency block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#schedule_frequency QuicksightRefreshSchedule#schedule_frequency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleFrequency", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequency\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScheduleFrequency
        {
            get => _scheduleFrequency;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequency[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleScheduleScheduleFrequency).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scheduleFrequency = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#start_after_date_time QuicksightRefreshSchedule#start_after_date_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startAfterDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartAfterDateTime
        {
            get;
            set;
        }
    }
}
