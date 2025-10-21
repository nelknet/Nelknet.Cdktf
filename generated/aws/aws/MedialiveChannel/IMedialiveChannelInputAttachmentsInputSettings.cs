using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings")]
    public interface IMedialiveChannelInputAttachmentsInputSettings
    {
        /// <summary>audio_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_selector MedialiveChannel#audio_selector}
        /// </remarks>
        [JsiiProperty(name: "audioSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AudioSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>caption_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_selector MedialiveChannel#caption_selector}
        /// </remarks>
        [JsiiProperty(name: "captionSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaptionSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#deblock_filter MedialiveChannel#deblock_filter}.</summary>
        [JsiiProperty(name: "deblockFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeblockFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#denoise_filter MedialiveChannel#denoise_filter}.</summary>
        [JsiiProperty(name: "denoiseFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DenoiseFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filter_strength MedialiveChannel#filter_strength}.</summary>
        [JsiiProperty(name: "filterStrength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FilterStrength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_filter MedialiveChannel#input_filter}.</summary>
        [JsiiProperty(name: "inputFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_input_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#network_input_settings MedialiveChannel#network_input_settings}
        /// </remarks>
        [JsiiProperty(name: "networkInputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings? NetworkInputSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_pid MedialiveChannel#scte35_pid}.</summary>
        [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Scte35Pid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#smpte2038_data_preference MedialiveChannel#smpte2038_data_preference}.</summary>
        [JsiiProperty(name: "smpte2038DataPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Smpte2038DataPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_end_behavior MedialiveChannel#source_end_behavior}.</summary>
        [JsiiProperty(name: "sourceEndBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceEndBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>video_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_selector MedialiveChannel#video_selector}
        /// </remarks>
        [JsiiProperty(name: "videoSelector", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsVideoSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsVideoSelector? VideoSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audio_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_selector MedialiveChannel#audio_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audioSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AudioSelector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>caption_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_selector MedialiveChannel#caption_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captionSelector", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelector\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CaptionSelector
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#deblock_filter MedialiveChannel#deblock_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deblockFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeblockFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#denoise_filter MedialiveChannel#denoise_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "denoiseFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DenoiseFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#filter_strength MedialiveChannel#filter_strength}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterStrength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FilterStrength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_filter MedialiveChannel#input_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_input_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#network_input_settings MedialiveChannel#network_input_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings? NetworkInputSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_pid MedialiveChannel#scte35_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Scte35Pid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#smpte2038_data_preference MedialiveChannel#smpte2038_data_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smpte2038DataPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Smpte2038DataPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_end_behavior MedialiveChannel#source_end_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceEndBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceEndBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>video_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_selector MedialiveChannel#video_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videoSelector", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsVideoSelector\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsVideoSelector? VideoSelector
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsVideoSelector?>();
            }
        }
    }
}
