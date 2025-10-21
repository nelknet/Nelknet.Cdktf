using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobScheduleFrequency), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobScheduleFrequency")]
    public interface IMacie2ClassificationJobScheduleFrequency
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#daily_schedule Macie2ClassificationJob#daily_schedule}.</summary>
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DailySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#monthly_schedule Macie2ClassificationJob#monthly_schedule}.</summary>
        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MonthlySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#weekly_schedule Macie2ClassificationJob#weekly_schedule}.</summary>
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeeklySchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobScheduleFrequency), fullyQualifiedName: "aws.macie2ClassificationJob.Macie2ClassificationJobScheduleFrequency")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2ClassificationJob.IMacie2ClassificationJobScheduleFrequency
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#daily_schedule Macie2ClassificationJob#daily_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dailySchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DailySchedule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#monthly_schedule Macie2ClassificationJob#monthly_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthlySchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MonthlySchedule
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#weekly_schedule Macie2ClassificationJob#weekly_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weeklySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeeklySchedule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
