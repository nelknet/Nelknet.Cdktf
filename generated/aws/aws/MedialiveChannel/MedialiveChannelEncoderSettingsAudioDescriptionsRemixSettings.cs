using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings")]
    public class MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings
    {
        private object _channelMappings;

        /// <summary>channel_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_mappings MedialiveChannel#channel_mappings}
        /// </remarks>
        [JsiiProperty(name: "channelMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings\"},\"kind\":\"array\"}}]}}")]
        public object ChannelMappings
        {
            get => _channelMappings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _channelMappings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_in MedialiveChannel#channels_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channelsIn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChannelsIn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_out MedialiveChannel#channels_out}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channelsOut", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChannelsOut
        {
            get;
            set;
        }
    }
}
