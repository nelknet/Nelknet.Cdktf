using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig")]
    public class MedialiveChannelEncoderSettingsTimecodeConfig : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source MedialiveChannel#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sync_threshold MedialiveChannel#sync_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "syncThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SyncThreshold
        {
            get;
            set;
        }
    }
}
