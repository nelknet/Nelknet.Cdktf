using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplexProgram
{
    [JsiiByValue(fqn: "aws.medialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings")]
    public class MedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings : aws.MedialiveMultiplexProgram.IMedialiveMultiplexProgramMultiplexProgramSettingsVideoSettingsStatmuxSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#maximum_bitrate MedialiveMultiplexProgram#maximum_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumBitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#minimum_bitrate MedialiveMultiplexProgram#minimum_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumBitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#priority MedialiveMultiplexProgram#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }
    }
}
