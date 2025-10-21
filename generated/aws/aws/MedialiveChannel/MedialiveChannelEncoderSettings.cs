using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettings")]
    public class MedialiveChannelEncoderSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettings
    {
        private object _outputGroups;

        /// <summary>output_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_groups MedialiveChannel#output_groups}
        /// </remarks>
        [JsiiProperty(name: "outputGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroups\"},\"kind\":\"array\"}}]}}")]
        public object OutputGroups
        {
            get => _outputGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputGroups = value;
            }
        }

        /// <summary>timecode_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timecode_config MedialiveChannel#timecode_config}
        /// </remarks>
        [JsiiProperty(name: "timecodeConfig", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig\"}")]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig TimecodeConfig
        {
            get;
            set;
        }

        private object? _audioDescriptions;

        /// <summary>audio_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_descriptions MedialiveChannel#audio_descriptions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audioDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AudioDescriptions
        {
            get => _audioDescriptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _audioDescriptions = value;
            }
        }

        /// <summary>avail_blanking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking MedialiveChannel#avail_blanking}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availBlanking", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking? AvailBlanking
        {
            get;
            set;
        }

        private object? _captionDescriptions;

        /// <summary>caption_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_descriptions MedialiveChannel#caption_descriptions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captionDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CaptionDescriptions
        {
            get => _captionDescriptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _captionDescriptions = value;
            }
        }

        /// <summary>global_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#global_configuration MedialiveChannel#global_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "globalConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration? GlobalConfiguration
        {
            get;
            set;
        }

        /// <summary>motion_graphics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#motion_graphics_configuration MedialiveChannel#motion_graphics_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "motionGraphicsConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfiguration\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration
        {
            get;
            set;
        }

        /// <summary>nielsen_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_configuration MedialiveChannel#nielsen_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nielsenConfiguration", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration? NielsenConfiguration
        {
            get;
            set;
        }

        private object? _videoDescriptions;

        /// <summary>video_descriptions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_descriptions MedialiveChannel#video_descriptions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "videoDescriptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VideoDescriptions
        {
            get => _videoDescriptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _videoDescriptions = value;
            }
        }
    }
}
