using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#column_depth MedialiveChannel#column_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ColumnDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#include_fec MedialiveChannel#include_fec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeFec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IncludeFec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#row_length MedialiveChannel#row_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rowLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RowLength
        {
            get;
            set;
        }
    }
}
