using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_selector_name MedialiveChannel#audio_selector_name}.</summary>
        [JsiiProperty(name: "audioSelectorName", typeJson: "{\"primitive\":\"string\"}")]
        public string AudioSelectorName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_silence_threshold_msec MedialiveChannel#audio_silence_threshold_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioSilenceThresholdMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AudioSilenceThresholdMsec
        {
            get;
            set;
        }
    }
}
