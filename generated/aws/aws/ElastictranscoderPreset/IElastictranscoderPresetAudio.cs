using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetAudio), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetAudio")]
    public interface IElastictranscoderPresetAudio
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#audio_packing_mode ElastictranscoderPreset#audio_packing_mode}.</summary>
        [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AudioPackingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_rate ElastictranscoderPreset#bit_rate}.</summary>
        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#channels ElastictranscoderPreset#channels}.</summary>
        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Channels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#codec ElastictranscoderPreset#codec}.</summary>
        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Codec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#sample_rate ElastictranscoderPreset#sample_rate}.</summary>
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SampleRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetAudio), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetAudio")]
        internal sealed class _Proxy : DeputyBase, aws.ElastictranscoderPreset.IElastictranscoderPresetAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#audio_packing_mode ElastictranscoderPreset#audio_packing_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AudioPackingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_rate ElastictranscoderPreset#bit_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitRate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#channels ElastictranscoderPreset#channels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Channels
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#codec ElastictranscoderPreset#codec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Codec
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#sample_rate ElastictranscoderPreset#sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SampleRate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
