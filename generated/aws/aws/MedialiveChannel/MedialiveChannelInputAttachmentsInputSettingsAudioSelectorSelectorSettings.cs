using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettings")]
    public class MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettings : aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettings
    {
        /// <summary>audio_hls_rendition_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_hls_rendition_selection MedialiveChannel#audio_hls_rendition_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioHlsRenditionSelection", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection? AudioHlsRenditionSelection
        {
            get;
            set;
        }

        /// <summary>audio_language_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_language_selection MedialiveChannel#audio_language_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioLanguageSelection", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection? AudioLanguageSelection
        {
            get;
            set;
        }

        /// <summary>audio_pid_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_pid_selection MedialiveChannel#audio_pid_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioPidSelection", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection? AudioPidSelection
        {
            get;
            set;
        }

        /// <summary>audio_track_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_track_selection MedialiveChannel#audio_track_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioTrackSelection", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection? AudioTrackSelection
        {
            get;
            set;
        }
    }
}
