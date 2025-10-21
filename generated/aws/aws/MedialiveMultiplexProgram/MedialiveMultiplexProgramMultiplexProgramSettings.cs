using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplexProgram
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettings")]
    public class MedialiveMultiplexProgramMultiplexProgramSettings : aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#preferred_channel_pipeline MedialiveMultiplexProgram#preferred_channel_pipeline}.</summary>
        [JsiiProperty(name: "preferredChannelPipeline", typeJson: "{\"primitive\":\"string\"}")]
        public string PreferredChannelPipeline
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#program_number MedialiveMultiplexProgram#program_number}.</summary>
        [JsiiProperty(name: "programNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double ProgramNumber
        {
            get;
            set;
        }

        private object? _serviceDescriptor;

        /// <summary>service_descriptor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#service_descriptor MedialiveMultiplexProgram#service_descriptor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceDescriptor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsServiceDescriptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServiceDescriptor
        {
            get => _serviceDescriptor;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsServiceDescriptor[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsServiceDescriptor).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceDescriptor = value;
            }
        }

        private object? _videoSettings;

        /// <summary>video_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#video_settings MedialiveMultiplexProgram#video_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "videoSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VideoSettings
        {
            get => _videoSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _videoSettings = value;
            }
        }
    }
}
