using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    [JsiiInterface(nativeType: typeof(ISsmcontactsRotationRecurrenceMonthlySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings")]
    public interface ISsmcontactsRotationRecurrenceMonthlySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_month SsmcontactsRotation#day_of_month}.</summary>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
        double DayOfMonth
        {
            get;
        }

        /// <summary>hand_off_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hand_off_time SsmcontactsRotation#hand_off_time}
        /// </remarks>
        [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HandOffTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmcontactsRotationRecurrenceMonthlySettings), fullyQualifiedName: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettings")]
        internal sealed class _Proxy : DeputyBase, aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceMonthlySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#day_of_month SsmcontactsRotation#day_of_month}.</summary>
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}")]
            public double DayOfMonth
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>hand_off_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hand_off_time SsmcontactsRotation#hand_off_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handOffTime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceMonthlySettingsHandOffTime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HandOffTime
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
