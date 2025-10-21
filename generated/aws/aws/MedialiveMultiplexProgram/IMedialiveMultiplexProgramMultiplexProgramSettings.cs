using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplexProgram
{
    [JsiiInterface(nativeType: typeof(IMedialiveMultiplexProgramMultiplexProgramSettings), fullyQualifiedName: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettings")]
    public interface IMedialiveMultiplexProgramMultiplexProgramSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#preferred_channel_pipeline MedialiveMultiplexProgram#preferred_channel_pipeline}.</summary>
        [JsiiProperty(name: "preferredChannelPipeline", typeJson: "{\"primitive\":\"string\"}")]
        string PreferredChannelPipeline
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#program_number MedialiveMultiplexProgram#program_number}.</summary>
        [JsiiProperty(name: "programNumber", typeJson: "{\"primitive\":\"number\"}")]
        double ProgramNumber
        {
            get;
        }

        /// <summary>service_descriptor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#service_descriptor MedialiveMultiplexProgram#service_descriptor}
        /// </remarks>
        [JsiiProperty(name: "serviceDescriptor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsServiceDescriptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceDescriptor
        {
            get
            {
                return null;
            }
        }

        /// <summary>video_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#video_settings MedialiveMultiplexProgram#video_settings}
        /// </remarks>
        [JsiiProperty(name: "videoSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VideoSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveMultiplexProgramMultiplexProgramSettings), fullyQualifiedName: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#preferred_channel_pipeline MedialiveMultiplexProgram#preferred_channel_pipeline}.</summary>
            [JsiiProperty(name: "preferredChannelPipeline", typeJson: "{\"primitive\":\"string\"}")]
            public string PreferredChannelPipeline
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#program_number MedialiveMultiplexProgram#program_number}.</summary>
            [JsiiProperty(name: "programNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double ProgramNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>service_descriptor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#service_descriptor MedialiveMultiplexProgram#service_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDescriptor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsServiceDescriptor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServiceDescriptor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>video_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#video_settings MedialiveMultiplexProgram#video_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "videoSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VideoSettings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
