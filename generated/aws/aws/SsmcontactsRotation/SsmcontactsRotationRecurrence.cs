using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrence")]
    public class SsmcontactsRotationRecurrence : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#number_of_on_calls SsmcontactsRotation#number_of_on_calls}.</summary>
        [JsiiProperty(name: "numberOfOnCalls", typeJson: "{\"primitive\":\"number\"}")]
        public double NumberOfOnCalls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#recurrence_multiplier SsmcontactsRotation#recurrence_multiplier}.</summary>
        [JsiiProperty(name: "recurrenceMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        public double RecurrenceMultiplier
        {
            get;
            set;
        }

        private object? _dailySettings;

        /// <summary>daily_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#daily_settings SsmcontactsRotation#daily_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dailySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DailySettings
        {
            get => _dailySettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dailySettings = value;
            }
        }

        private object? _monthlySettings;

        /// <summary>monthly_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#monthly_settings SsmcontactsRotation#monthly_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monthlySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MonthlySettings
        {
            get => _monthlySettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monthlySettings = value;
            }
        }

        private object? _shiftCoverages;

        /// <summary>shift_coverages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#shift_coverages SsmcontactsRotation#shift_coverages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shiftCoverages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ShiftCoverages
        {
            get => _shiftCoverages;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoverages).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shiftCoverages = value;
            }
        }

        private object? _weeklySettings;

        /// <summary>weekly_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#weekly_settings SsmcontactsRotation#weekly_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weeklySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WeeklySettings
        {
            get => _weeklySettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _weeklySettings = value;
            }
        }
    }
}
