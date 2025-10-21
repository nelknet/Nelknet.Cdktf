using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MediaConvertQueue
{
    [JsiiInterface(nativeType: typeof(IMediaConvertQueueReservationPlanSettings), fullyQualifiedName: "aws.mediaConvertQueue.MediaConvertQueueReservationPlanSettings")]
    public interface IMediaConvertQueueReservationPlanSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#commitment MediaConvertQueue#commitment}.</summary>
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        string Commitment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#renewal_type MediaConvertQueue#renewal_type}.</summary>
        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
        string RenewalType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#reserved_slots MediaConvertQueue#reserved_slots}.</summary>
        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
        double ReservedSlots
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaConvertQueueReservationPlanSettings), fullyQualifiedName: "aws.mediaConvertQueue.MediaConvertQueueReservationPlanSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MediaConvertQueue.IMediaConvertQueueReservationPlanSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#commitment MediaConvertQueue#commitment}.</summary>
            [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
            public string Commitment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#renewal_type MediaConvertQueue#renewal_type}.</summary>
            [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
            public string RenewalType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#reserved_slots MediaConvertQueue#reserved_slots}.</summary>
            [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
            public double ReservedSlots
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
