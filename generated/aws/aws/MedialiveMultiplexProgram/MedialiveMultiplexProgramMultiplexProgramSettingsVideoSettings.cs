using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplexProgram
{
    [JsiiByValue(fqn: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings")]
    public class MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings : aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#constant_bitrate MedialiveMultiplexProgram#constant_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "constantBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConstantBitrate
        {
            get;
            set;
        }

        private object? _statmuxSettings;

        /// <summary>statmux_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#statmux_settings MedialiveMultiplexProgram#statmux_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statmuxSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatmuxSettings
        {
            get => _statmuxSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statmuxSettings = value;
            }
        }
    }
}
