using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings")]
    public interface IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings
    {
        /// <summary>channel_mappings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_mappings MedialiveChannel#channel_mappings}
        /// </remarks>
        [JsiiProperty(name: "channelMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings\"},\"kind\":\"array\"}}]}}")]
        object ChannelMappings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_in MedialiveChannel#channels_in}.</summary>
        [JsiiProperty(name: "channelsIn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChannelsIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_out MedialiveChannel#channels_out}.</summary>
        [JsiiProperty(name: "channelsOut", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChannelsOut
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>channel_mappings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_mappings MedialiveChannel#channel_mappings}
            /// </remarks>
            [JsiiProperty(name: "channelMappings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings\"},\"kind\":\"array\"}}]}}")]
            public object ChannelMappings
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_in MedialiveChannel#channels_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channelsIn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChannelsIn
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channels_out MedialiveChannel#channels_out}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channelsOut", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChannelsOut
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
