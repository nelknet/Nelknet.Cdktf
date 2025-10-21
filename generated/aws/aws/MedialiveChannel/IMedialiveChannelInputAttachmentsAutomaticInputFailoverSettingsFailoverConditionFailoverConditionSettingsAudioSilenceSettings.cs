using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings")]
    public interface IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_selector_name MedialiveChannel#audio_selector_name}.</summary>
        [JsiiProperty(name: "audioSelectorName", typeJson: "{\"primitive\":\"string\"}")]
        string AudioSelectorName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_silence_threshold_msec MedialiveChannel#audio_silence_threshold_msec}.</summary>
        [JsiiProperty(name: "audioSilenceThresholdMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AudioSilenceThresholdMsec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_selector_name MedialiveChannel#audio_selector_name}.</summary>
            [JsiiProperty(name: "audioSelectorName", typeJson: "{\"primitive\":\"string\"}")]
            public string AudioSelectorName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_silence_threshold_msec MedialiveChannel#audio_silence_threshold_msec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioSilenceThresholdMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AudioSilenceThresholdMsec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
