using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiInterface(nativeType: typeof(IElastictranscoderPresetAudioCodecOptions), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions")]
    public interface IElastictranscoderPresetAudioCodecOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_depth ElastictranscoderPreset#bit_depth}.</summary>
        [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_order ElastictranscoderPreset#bit_order}.</summary>
        [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BitOrder
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#profile ElastictranscoderPreset#profile}.</summary>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#signed ElastictranscoderPreset#signed}.</summary>
        [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Signed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElastictranscoderPresetAudioCodecOptions), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetAudioCodecOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ElastictranscoderPreset.IElastictranscoderPresetAudioCodecOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_depth ElastictranscoderPreset#bit_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bitDepth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitDepth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#bit_order ElastictranscoderPreset#bit_order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bitOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BitOrder
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#profile ElastictranscoderPreset#profile}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastictranscoder_preset#signed ElastictranscoderPreset#signed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Signed
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
