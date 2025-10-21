using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrence), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrence")]
    public interface ISsmcontactsRotationRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#number_of_on_calls SsmcontactsRotation#number_of_on_calls}.</summary>
        [JsiiProperty(name: "numberOfOnCalls", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfOnCalls
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#recurrence_multiplier SsmcontactsRotation#recurrence_multiplier}.</summary>
        [JsiiProperty(name: "recurrenceMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        double RecurrenceMultiplier
        {
            get;
        }

        /// <summary>daily_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#daily_settings SsmcontactsRotation#daily_settings}
        /// </remarks>
        [JsiiProperty(name: "dailySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DailySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>monthly_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#monthly_settings SsmcontactsRotation#monthly_settings}
        /// </remarks>
        [JsiiProperty(name: "monthlySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MonthlySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>shift_coverages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#shift_coverages SsmcontactsRotation#shift_coverages}
        /// </remarks>
        [JsiiProperty(name: "shiftCoverages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShiftCoverages
        {
            get
            {
                return null;
            }
        }

        /// <summary>weekly_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#weekly_settings SsmcontactsRotation#weekly_settings}
        /// </remarks>
        [JsiiProperty(name: "weeklySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WeeklySettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrence), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrence")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#number_of_on_calls SsmcontactsRotation#number_of_on_calls}.</summary>
            [JsiiProperty(name: "numberOfOnCalls", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfOnCalls
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#recurrence_multiplier SsmcontactsRotation#recurrence_multiplier}.</summary>
            [JsiiProperty(name: "recurrenceMultiplier", typeJson: "{\"primitive\":\"number\"}")]
            public double RecurrenceMultiplier
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>daily_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#daily_settings SsmcontactsRotation#daily_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DailySettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monthly_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#monthly_settings SsmcontactsRotation#monthly_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monthlySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MonthlySettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>shift_coverages block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#shift_coverages SsmcontactsRotation#shift_coverages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shiftCoverages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoverages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ShiftCoverages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>weekly_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#weekly_settings SsmcontactsRotation#weekly_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weeklySettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WeeklySettings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
