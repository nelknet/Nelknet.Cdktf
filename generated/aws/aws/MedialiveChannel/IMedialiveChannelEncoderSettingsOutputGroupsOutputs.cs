using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputs), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputs")]
    public interface IMedialiveChannelEncoderSettingsOutputGroupsOutputs
    {
        /// <summary>output_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_settings MedialiveChannel#output_settings}
        /// </remarks>
        [JsiiProperty(name: "outputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings\"}")]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings OutputSettings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_description_names MedialiveChannel#audio_description_names}.</summary>
        [JsiiProperty(name: "audioDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AudioDescriptionNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_description_names MedialiveChannel#caption_description_names}.</summary>
        [JsiiProperty(name: "captionDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CaptionDescriptionNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_name MedialiveChannel#output_name}.</summary>
        [JsiiProperty(name: "outputName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_description_name MedialiveChannel#video_description_name}.</summary>
        [JsiiProperty(name: "videoDescriptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VideoDescriptionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputs), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputs")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>output_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_settings MedialiveChannel#output_settings}
            /// </remarks>
            [JsiiProperty(name: "outputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings\"}")]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings OutputSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_description_names MedialiveChannel#audio_description_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AudioDescriptionNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#caption_description_names MedialiveChannel#caption_description_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captionDescriptionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CaptionDescriptionNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_name MedialiveChannel#output_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_description_name MedialiveChannel#video_description_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "videoDescriptionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VideoDescriptionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
