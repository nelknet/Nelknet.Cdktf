using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrenceDailySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings")]
    public interface ISsmcontactsRotationRecurrenceDailySettings
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

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrenceDailySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceDailySettings")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceDailySettings
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
