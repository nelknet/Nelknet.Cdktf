using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings")]
    public interface IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
        [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Bitrate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#coding_mode MedialiveChannel#coding_mode}.</summary>
        [JsiiProperty(name: "codingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CodingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dialnorm MedialiveChannel#dialnorm}.</summary>
        [JsiiProperty(name: "dialnorm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dialnorm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_line MedialiveChannel#drc_line}.</summary>
        [JsiiProperty(name: "drcLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrcLine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_rf MedialiveChannel#drc_rf}.</summary>
        [JsiiProperty(name: "drcRf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrcRf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height_trim MedialiveChannel#height_trim}.</summary>
        [JsiiProperty(name: "heightTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HeightTrim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#surround_trim MedialiveChannel#surround_trim}.</summary>
        [JsiiProperty(name: "surroundTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SurroundTrim
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#bitrate MedialiveChannel#bitrate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Bitrate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#coding_mode MedialiveChannel#coding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "codingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CodingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#dialnorm MedialiveChannel#dialnorm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dialnorm", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dialnorm
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_line MedialiveChannel#drc_line}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drcLine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrcLine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#drc_rf MedialiveChannel#drc_rf}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drcRf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrcRf
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height_trim MedialiveChannel#height_trim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "heightTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HeightTrim
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#surround_trim MedialiveChannel#surround_trim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "surroundTrim", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SurroundTrim
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
