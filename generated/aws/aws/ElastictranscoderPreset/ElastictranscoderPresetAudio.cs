using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiByValue(fqn: "aws.elastictranscoderPreset.ElastictranscoderPresetAudio")]
    public class ElastictranscoderPresetAudio : aws.ElastictranscoderPreset.IElastictranscoderPresetAudio
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#audio_packing_mode ElastictranscoderPreset#audio_packing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AudioPackingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_rate ElastictranscoderPreset#bit_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitRate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#channels ElastictranscoderPreset#channels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Channels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#codec ElastictranscoderPreset#codec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Codec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#sample_rate ElastictranscoderPreset#sample_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SampleRate
        {
            get;
            set;
        }
    }
}
