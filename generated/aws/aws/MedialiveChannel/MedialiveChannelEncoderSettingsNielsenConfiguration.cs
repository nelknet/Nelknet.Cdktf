using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration")]
    public class MedialiveChannelEncoderSettingsNielsenConfiguration : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#distributor_id MedialiveChannel#distributor_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distributorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DistributorId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_pcm_to_id3_tagging MedialiveChannel#nielsen_pcm_to_id3_tagging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nielsenPcmToId3Tagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NielsenPcmToId3Tagging
        {
            get;
            set;
        }
    }
}
