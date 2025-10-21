using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputs")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputs : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputs
    {
        /// <summary>output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_settings MedialiveChannel#output_settings}
        /// </remarks>
        [JsiiProperty(name: "outputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings\"}")]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings OutputSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_description_names MedialiveChannel#audio_description_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AudioDescriptionNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_description_names MedialiveChannel#caption_description_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captionDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CaptionDescriptionNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_name MedialiveChannel#output_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_description_name MedialiveChannel#video_description_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "videoDescriptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VideoDescriptionName
        {
            get;
            set;
        }
    }
}
