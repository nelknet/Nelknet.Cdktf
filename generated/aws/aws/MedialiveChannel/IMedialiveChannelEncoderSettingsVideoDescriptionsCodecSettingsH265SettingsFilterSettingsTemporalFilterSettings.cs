using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings")]
    public interface IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#post_filter_sharpening MedialiveChannel#post_filter_sharpening}.</summary>
        [JsiiProperty(name: "postFilterSharpening", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostFilterSharpening
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#strength MedialiveChannel#strength}.</summary>
        [JsiiProperty(name: "strength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Strength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#post_filter_sharpening MedialiveChannel#post_filter_sharpening}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postFilterSharpening", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostFilterSharpening
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#strength MedialiveChannel#strength}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Strength
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
