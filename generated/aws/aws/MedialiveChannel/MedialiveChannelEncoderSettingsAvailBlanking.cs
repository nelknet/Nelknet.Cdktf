using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking")]
    public class MedialiveChannelEncoderSettingsAvailBlanking : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking
    {
        /// <summary>avail_blanking_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking_image MedialiveChannel#avail_blanking_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availBlankingImage", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }
    }
}
