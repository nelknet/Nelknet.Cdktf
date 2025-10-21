using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings")]
    public interface IMedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_check_digit_string MedialiveChannel#cbet_check_digit_string}.</summary>
        [JsiiProperty(name: "cbetCheckDigitString", typeJson: "{\"primitive\":\"string\"}")]
        string CbetCheckDigitString
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_stepaside MedialiveChannel#cbet_stepaside}.</summary>
        [JsiiProperty(name: "cbetStepaside", typeJson: "{\"primitive\":\"string\"}")]
        string CbetStepaside
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#csid MedialiveChannel#csid}.</summary>
        [JsiiProperty(name: "csid", typeJson: "{\"primitive\":\"string\"}")]
        string Csid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_check_digit_string MedialiveChannel#cbet_check_digit_string}.</summary>
            [JsiiProperty(name: "cbetCheckDigitString", typeJson: "{\"primitive\":\"string\"}")]
            public string CbetCheckDigitString
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#cbet_stepaside MedialiveChannel#cbet_stepaside}.</summary>
            [JsiiProperty(name: "cbetStepaside", typeJson: "{\"primitive\":\"string\"}")]
            public string CbetStepaside
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#csid MedialiveChannel#csid}.</summary>
            [JsiiProperty(name: "csid", typeJson: "{\"primitive\":\"string\"}")]
            public string Csid
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
