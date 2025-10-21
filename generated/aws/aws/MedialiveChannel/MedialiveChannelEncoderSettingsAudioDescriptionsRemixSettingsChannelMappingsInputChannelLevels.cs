using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#gain MedialiveChannel#gain}.</summary>
        [JsiiProperty(name: "gain", typeJson: "{\"primitive\":\"number\"}")]
        public double Gain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_channel MedialiveChannel#input_channel}.</summary>
        [JsiiProperty(name: "inputChannel", typeJson: "{\"primitive\":\"number\"}")]
        public double InputChannel
        {
            get;
            set;
        }
    }
}
