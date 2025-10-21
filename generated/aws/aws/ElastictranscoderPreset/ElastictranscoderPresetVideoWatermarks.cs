using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiByValue(fqn: "aws.elastictranscoderPreset.ElastictranscoderPresetVideoWatermarks")]
    public class ElastictranscoderPresetVideoWatermarks : aws.ElastictranscoderPreset.IElastictranscoderPresetVideoWatermarks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#horizontal_align ElastictranscoderPreset#horizontal_align}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "horizontalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HorizontalAlign
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#horizontal_offset ElastictranscoderPreset#horizontal_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "horizontalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HorizontalOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#id ElastictranscoderPreset#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#opacity ElastictranscoderPreset#opacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "opacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Opacity
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#target ElastictranscoderPreset#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#vertical_align ElastictranscoderPreset#vertical_align}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verticalAlign", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerticalAlign
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#vertical_offset ElastictranscoderPreset#vertical_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "verticalOffset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VerticalOffset
        {
            get;
            set;
        }
    }
}
