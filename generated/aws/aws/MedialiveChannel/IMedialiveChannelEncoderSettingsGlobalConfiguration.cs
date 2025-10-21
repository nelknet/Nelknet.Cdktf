using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsGlobalConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration")]
    public interface IMedialiveChannelEncoderSettingsGlobalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#initial_audio_gain MedialiveChannel#initial_audio_gain}.</summary>
        [JsiiProperty(name: "initialAudioGain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialAudioGain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_end_action MedialiveChannel#input_end_action}.</summary>
        [JsiiProperty(name: "inputEndAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputEndAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_loss_behavior block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_behavior MedialiveChannel#input_loss_behavior}
        /// </remarks>
        [JsiiProperty(name: "inputLossBehavior", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_locking_mode MedialiveChannel#output_locking_mode}.</summary>
        [JsiiProperty(name: "outputLockingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputLockingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_timing_source MedialiveChannel#output_timing_source}.</summary>
        [JsiiProperty(name: "outputTimingSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputTimingSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#support_low_framerate_inputs MedialiveChannel#support_low_framerate_inputs}.</summary>
        [JsiiProperty(name: "supportLowFramerateInputs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SupportLowFramerateInputs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsGlobalConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#initial_audio_gain MedialiveChannel#initial_audio_gain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialAudioGain", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialAudioGain
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_end_action MedialiveChannel#input_end_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputEndAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputEndAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_loss_behavior block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_loss_behavior MedialiveChannel#input_loss_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputLossBehavior", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehavior
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsGlobalConfigurationInputLossBehavior?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_locking_mode MedialiveChannel#output_locking_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputLockingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputLockingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#output_timing_source MedialiveChannel#output_timing_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputTimingSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputTimingSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#support_low_framerate_inputs MedialiveChannel#support_low_framerate_inputs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportLowFramerateInputs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportLowFramerateInputs
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
