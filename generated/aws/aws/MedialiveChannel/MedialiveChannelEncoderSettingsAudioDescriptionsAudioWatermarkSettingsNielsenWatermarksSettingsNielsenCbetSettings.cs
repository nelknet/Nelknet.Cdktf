using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_check_digit_string MedialiveChannel#cbet_check_digit_string}.</summary>
        [JsiiProperty(name: "cbetCheckDigitString", typeJson: "{\"primitive\":\"string\"}")]
        public string CbetCheckDigitString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_stepaside MedialiveChannel#cbet_stepaside}.</summary>
        [JsiiProperty(name: "cbetStepaside", typeJson: "{\"primitive\":\"string\"}")]
        public string CbetStepaside
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#csid MedialiveChannel#csid}.</summary>
        [JsiiProperty(name: "csid", typeJson: "{\"primitive\":\"string\"}")]
        public string Csid
        {
            get;
            set;
        }
    }
}
