using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsHandOffTime")]
    public interface ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hour_of_day SsmcontactsRotation#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        double HourOfDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#minute_of_hour SsmcontactsRotation#minute_of_hour}.</summary>
        [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}")]
        double MinuteOfHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsHandOffTime")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettingsHandOffTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hour_of_day SsmcontactsRotation#hour_of_day}.</summary>
            [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
            public double HourOfDay
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#minute_of_hour SsmcontactsRotation#minute_of_hour}.</summary>
            [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}")]
            public double MinuteOfHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
