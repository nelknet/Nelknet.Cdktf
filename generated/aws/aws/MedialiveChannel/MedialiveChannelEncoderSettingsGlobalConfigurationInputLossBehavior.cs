using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior")]
    public class MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#black_frame_msec MedialiveChannel#black_frame_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blackFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlackFrameMsec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_color MedialiveChannel#input_loss_image_color}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputLossImageColor
        {
            get;
            set;
        }

        /// <summary>input_loss_image_slate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_slate MedialiveChannel#input_loss_image_slate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageSlate", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate\"}", isOptional: true)]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_type MedialiveChannel#input_loss_image_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLossImageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputLossImageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#repeat_frame_msec MedialiveChannel#repeat_frame_msec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repeatFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RepeatFrameMsec
        {
            get;
            set;
        }
    }
}
