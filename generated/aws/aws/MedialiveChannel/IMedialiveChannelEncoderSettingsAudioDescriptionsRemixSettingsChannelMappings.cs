using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings")]
    public interface IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
    {
        /// <summary>input_channel_levels block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_channel_levels MedialiveChannel#input_channel_levels}
        /// </remarks>
        [JsiiProperty(name: "inputChannelLevels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels\"},\"kind\":\"array\"}}]}}")]
        object InputChannelLevels
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_channel MedialiveChannel#output_channel}.</summary>
        [JsiiProperty(name: "outputChannel", typeJson: "{\"primitive\":\"number\"}")]
        double OutputChannel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>input_channel_levels block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_channel_levels MedialiveChannel#input_channel_levels}
            /// </remarks>
            [JsiiProperty(name: "inputChannelLevels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels\"},\"kind\":\"array\"}}]}}")]
            public object InputChannelLevels
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_channel MedialiveChannel#output_channel}.</summary>
            [JsiiProperty(name: "outputChannel", typeJson: "{\"primitive\":\"number\"}")]
            public double OutputChannel
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
