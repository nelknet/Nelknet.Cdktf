using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightRefreshSchedule
{
    [JsiiInterface(nativeType: typeof(IQuicksightRefreshScheduleSchedule), fullyQualifiedName: "aws.quicksightRefreshSchedule.QuicksightRefreshScheduleSchedule")]
    public interface IQuicksightRefreshScheduleSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#refresh_type QuicksightRefreshSchedule#refresh_type}.</summary>
        [JsiiProperty(name: "refreshType", typeJson: "{\"primitive\":\"string\"}")]
        string RefreshType
        {
            get;
        }

        /// <summary>schedule_frequency block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#schedule_frequency QuicksightRefreshSchedule#schedule_frequency}
        /// </remarks>
        [JsiiProperty(name: "scheduleFrequency", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequency\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScheduleFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#start_after_date_time QuicksightRefreshSchedule#start_after_date_time}.</summary>
        [JsiiProperty(name: "startAfterDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartAfterDateTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightRefreshScheduleSchedule), fullyQualifiedName: "aws.quicksightRefreshSchedule.QuicksightRefreshScheduleSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightRefreshSchedule.IQuicksightRefreshScheduleSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#refresh_type QuicksightRefreshSchedule#refresh_type}.</summary>
            [JsiiProperty(name: "refreshType", typeJson: "{\"primitive\":\"string\"}")]
            public string RefreshType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schedule_frequency block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#schedule_frequency QuicksightRefreshSchedule#schedule_frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleFrequency", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightRefreshSchedule.QuicksightRefreshScheduleScheduleScheduleFrequency\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScheduleFrequency
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_refresh_schedule#start_after_date_time QuicksightRefreshSchedule#start_after_date_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startAfterDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartAfterDateTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
