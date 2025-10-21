using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings")]
    public class MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
    {
        /// <summary>audio_silence_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_silence_settings MedialiveChannel#audio_silence_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioSilenceSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings? AudioSilenceSettings
        {
            get;
            set;
        }

        /// <summary>input_loss_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_settings MedialiveChannel#input_loss_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings? InputLossSettings
        {
            get;
            set;
        }

        /// <summary>video_black_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_black_settings MedialiveChannel#video_black_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "videoBlackSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings? VideoBlackSettings
        {
            get;
            set;
        }
    }
}
