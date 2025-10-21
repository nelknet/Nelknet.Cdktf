using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MediaConvertQueue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mediaConvertQueue.MediaConvertQueueReservationPlanSettings")]
    public class MediaConvertQueueReservationPlanSettings : aws.MediaConvertQueue.IMediaConvertQueueReservationPlanSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#commitment MediaConvertQueue#commitment}.</summary>
        [JsiiProperty(name: "commitment", typeJson: "{\"primitive\":\"string\"}")]
        public string Commitment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#renewal_type MediaConvertQueue#renewal_type}.</summary>
        [JsiiProperty(name: "renewalType", typeJson: "{\"primitive\":\"string\"}")]
        public string RenewalType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/media_convert_queue#reserved_slots MediaConvertQueue#reserved_slots}.</summary>
        [JsiiProperty(name: "reservedSlots", typeJson: "{\"primitive\":\"number\"}")]
        public double ReservedSlots
        {
            get;
            set;
        }
    }
}
