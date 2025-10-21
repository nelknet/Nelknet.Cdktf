using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiByValue(fqn: "aws.elastictranscoderPreset.ElastictranscoderPresetThumbnails")]
    public class ElastictranscoderPresetThumbnails : aws.ElastictranscoderPreset.IElastictranscoderPresetThumbnails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#aspect_ratio ElastictranscoderPreset#aspect_ratio}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aspectRatio", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AspectRatio
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#format ElastictranscoderPreset#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#interval ElastictranscoderPreset#interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#max_height ElastictranscoderPreset#max_height}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHeight", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxHeight
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#max_width ElastictranscoderPreset#max_width}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWidth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxWidth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#padding_policy ElastictranscoderPreset#padding_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paddingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaddingPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#resolution ElastictranscoderPreset#resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Resolution
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#sizing_policy ElastictranscoderPreset#sizing_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizingPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizingPolicy
        {
            get;
            set;
        }
    }
}
