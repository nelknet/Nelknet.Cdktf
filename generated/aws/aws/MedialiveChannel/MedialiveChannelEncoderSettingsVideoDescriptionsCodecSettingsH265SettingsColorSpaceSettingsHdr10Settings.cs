using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#max_cll MedialiveChannel#max_cll}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCll", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#max_fall MedialiveChannel#max_fall}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxFall", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxFall
        {
            get;
            set;
        }
    }
}
