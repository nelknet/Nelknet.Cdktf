using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfiguration")]
    public class MedialiveChannelEncoderSettingsMotionGraphicsConfiguration : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration
    {
        /// <summary>motion_graphics_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#motion_graphics_settings MedialiveChannel#motion_graphics_settings}
        /// </remarks>
        [JsiiProperty(name: "motionGraphicsSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings\"}")]
        public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings MotionGraphicsSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#motion_graphics_insertion MedialiveChannel#motion_graphics_insertion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "motionGraphicsInsertion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MotionGraphicsInsertion
        {
            get;
            set;
        }
    }
}
