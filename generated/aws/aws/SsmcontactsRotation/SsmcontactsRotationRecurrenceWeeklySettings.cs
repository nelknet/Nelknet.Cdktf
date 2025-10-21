using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings")]
    public class SsmcontactsRotationRecurrenceWeeklySettings : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_week SsmcontactsRotation#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        private object? _handOffTime;

        /// <summary>hand_off_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hand_off_time SsmcontactsRotation#hand_off_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HandOffTime
        {
            get => _handOffTime;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _handOffTime = value;
            }
        }
    }
}
