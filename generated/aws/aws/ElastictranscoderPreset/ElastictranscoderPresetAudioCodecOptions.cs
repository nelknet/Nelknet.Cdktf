using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiByValue(fqn: "aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions")]
    public class ElastictranscoderPresetAudioCodecOptions : aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_depth ElastictranscoderPreset#bit_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_order ElastictranscoderPreset#bit_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BitOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#profile ElastictranscoderPreset#profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#signed ElastictranscoderPreset#signed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Signed
        {
            get;
            set;
        }
    }
}
