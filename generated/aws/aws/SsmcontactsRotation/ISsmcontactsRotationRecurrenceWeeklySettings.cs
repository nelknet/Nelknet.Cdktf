using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrenceWeeklySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings")]
    public interface ISsmcontactsRotationRecurrenceWeeklySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_week SsmcontactsRotation#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>hand_off_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hand_off_time SsmcontactsRotation#hand_off_time}
        /// </remarks>
        [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HandOffTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrenceWeeklySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettings")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceWeeklySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_week SsmcontactsRotation#day_of_week}.</summary>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>hand_off_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hand_off_time SsmcontactsRotation#hand_off_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceWeeklySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HandOffTime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
