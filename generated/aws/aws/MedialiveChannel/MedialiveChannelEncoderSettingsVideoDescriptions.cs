using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptions")]
    public class MedialiveChannelEncoderSettingsVideoDescriptions : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#name MedialiveChannel#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>codec_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec_settings MedialiveChannel#codec_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codecSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettings\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettings? CodecSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height MedialiveChannel#height}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Height
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#respond_to_afd MedialiveChannel#respond_to_afd}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "respondToAfd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RespondToAfd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scaling_behavior MedialiveChannel#scaling_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScalingBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sharpness MedialiveChannel#sharpness}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sharpness", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Sharpness
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#width MedialiveChannel#width}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Width
        {
            get;
            set;
        }
    }
}
