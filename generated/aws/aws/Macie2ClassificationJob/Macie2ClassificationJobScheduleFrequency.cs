using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2ClassificationJob
{
    [JsiiByValue(fqn: "aws.macie2ClassificationJob.Macie2ClassificationJobScheduleFrequency")]
    public class Macie2ClassificationJobScheduleFrequency : aws.Macie2ClassificationJob.IMacie2ClassificationJobScheduleFrequency
    {
        private object? _dailySchedule;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#daily_schedule Macie2ClassificationJob#daily_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DailySchedule
        {
            get => _dailySchedule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dailySchedule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#monthly_schedule Macie2ClassificationJob#monthly_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MonthlySchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#weekly_schedule Macie2ClassificationJob#weekly_schedule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklySchedule
        {
            get;
            set;
        }
    }
}
