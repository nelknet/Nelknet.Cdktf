using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior")]
    public interface IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#black_frame_msec MedialiveChannel#black_frame_msec}.</summary>
        [JsiiProperty(name: "blackFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlackFrameMsec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_color MedialiveChannel#input_loss_image_color}.</summary>
        [JsiiProperty(name: "inputLossImageColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputLossImageColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_loss_image_slate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_slate MedialiveChannel#input_loss_image_slate}
        /// </remarks>
        [JsiiProperty(name: "inputLossImageSlate", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_type MedialiveChannel#input_loss_image_type}.</summary>
        [JsiiProperty(name: "inputLossImageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputLossImageType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#repeat_frame_msec MedialiveChannel#repeat_frame_msec}.</summary>
        [JsiiProperty(name: "repeatFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RepeatFrameMsec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#black_frame_msec MedialiveChannel#black_frame_msec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blackFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlackFrameMsec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_color MedialiveChannel#input_loss_image_color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputLossImageColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputLossImageColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_loss_image_slate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_slate MedialiveChannel#input_loss_image_slate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputLossImageSlate", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_image_type MedialiveChannel#input_loss_image_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputLossImageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputLossImageType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#repeat_frame_msec MedialiveChannel#repeat_frame_msec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repeatFrameMsec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RepeatFrameMsec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
