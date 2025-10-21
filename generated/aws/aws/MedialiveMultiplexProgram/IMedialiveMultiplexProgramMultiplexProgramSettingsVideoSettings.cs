using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplexProgram
{
    [JsiiInterface(nativeType: typeof(IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings), fullyQualifiedName: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings")]
    public interface IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#constant_bitrate MedialiveMultiplexProgram#constant_bitrate}.</summary>
        [JsiiProperty(name: "constantBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConstantBitrate
        {
            get
            {
                return null;
            }
        }

        /// <summary>statmux_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#statmux_settings MedialiveMultiplexProgram#statmux_settings}
        /// </remarks>
        [JsiiProperty(name: "statmuxSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatmuxSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings), fullyQualifiedName: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#constant_bitrate MedialiveMultiplexProgram#constant_bitrate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "constantBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConstantBitrate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>statmux_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#statmux_settings MedialiveMultiplexProgram#statmux_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statmuxSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatmuxSettings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
