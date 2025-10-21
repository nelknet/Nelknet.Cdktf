using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings")]
    public class SsmcontactsRotationRecurrenceMonthlySettings : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_month SsmcontactsRotation#day_of_month}.</summary>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
        public double DayOfMonth
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
        [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettingsHandOffTime[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettingsHandOffTime).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _handOffTime = value;
            }
        }
    }
}
