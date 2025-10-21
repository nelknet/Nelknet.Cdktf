using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettings")]
    public interface IMedialiveChannelEncoderSettings
    {
        /// <summary>output_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_groups MedialiveChannel#output_groups}
        /// </remarks>
        [JsiiProperty(name: "outputGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroups\"},\"kind\":\"array\"}}]}}")]
        object OutputGroups
        {
            get;
        }

        /// <summary>timecode_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_config MedialiveChannel#timecode_config}
        /// </remarks>
        [JsiiProperty(name: "timecodeConfig", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig\"}")]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig TimecodeConfig
        {
            get;
        }

        /// <summary>audio_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_descriptions MedialiveChannel#audio_descriptions}
        /// </remarks>
        [JsiiProperty(name: "audioDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AudioDescriptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>avail_blanking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking MedialiveChannel#avail_blanking}
        /// </remarks>
        [JsiiProperty(name: "availBlanking", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking? AvailBlanking
        {
            get
            {
                return null;
            }
        }

        /// <summary>caption_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_descriptions MedialiveChannel#caption_descriptions}
        /// </remarks>
        [JsiiProperty(name: "captionDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaptionDescriptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>global_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#global_configuration MedialiveChannel#global_configuration}
        /// </remarks>
        [JsiiProperty(name: "globalConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration? GlobalConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>motion_graphics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#motion_graphics_configuration MedialiveChannel#motion_graphics_configuration}
        /// </remarks>
        [JsiiProperty(name: "motionGraphicsConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>nielsen_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_configuration MedialiveChannel#nielsen_configuration}
        /// </remarks>
        [JsiiProperty(name: "nielsenConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration? NielsenConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>video_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_descriptions MedialiveChannel#video_descriptions}
        /// </remarks>
        [JsiiProperty(name: "videoDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VideoDescriptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>output_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_groups MedialiveChannel#output_groups}
            /// </remarks>
            [JsiiProperty(name: "outputGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroups\"},\"kind\":\"array\"}}]}}")]
            public object OutputGroups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>timecode_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_config MedialiveChannel#timecode_config}
            /// </remarks>
            [JsiiProperty(name: "timecodeConfig", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig\"}")]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig TimecodeConfig
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig>()!;
            }

            /// <summary>audio_descriptions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_descriptions MedialiveChannel#audio_descriptions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audioDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AudioDescriptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>avail_blanking block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking MedialiveChannel#avail_blanking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availBlanking", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking? AvailBlanking
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking?>();
            }

            /// <summary>caption_descriptions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_descriptions MedialiveChannel#caption_descriptions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captionDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CaptionDescriptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>global_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#global_configuration MedialiveChannel#global_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration? GlobalConfiguration
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration?>();
            }

            /// <summary>motion_graphics_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#motion_graphics_configuration MedialiveChannel#motion_graphics_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "motionGraphicsConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfiguration\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration?>();
            }

            /// <summary>nielsen_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_configuration MedialiveChannel#nielsen_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nielsenConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration? NielsenConfiguration
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration?>();
            }

            /// <summary>video_descriptions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_descriptions MedialiveChannel#video_descriptions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videoDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VideoDescriptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
