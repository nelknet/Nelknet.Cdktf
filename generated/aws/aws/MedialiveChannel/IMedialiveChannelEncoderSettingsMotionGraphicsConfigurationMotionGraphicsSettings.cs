using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings")]
    public interface IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
    {
        /// <summary>html_motion_graphics_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#html_motion_graphics_settings MedialiveChannel#html_motion_graphics_settings}
        /// </remarks>
        [JsiiProperty(name: "htmlMotionGraphicsSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings? HtmlMotionGraphicsSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>html_motion_graphics_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#html_motion_graphics_settings MedialiveChannel#html_motion_graphics_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "htmlMotionGraphicsSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings? HtmlMotionGraphicsSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings?>();
            }
        }
    }
}
