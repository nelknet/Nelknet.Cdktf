using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings : aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2TsSettingsDvbNitSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#network_id MedialiveChannel#network_id}.</summary>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}")]
        public double NetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#network_name MedialiveChannel#network_name}.</summary>
        [JsiiProperty(name: "networkName", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#rep_interval MedialiveChannel#rep_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "repInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RepInterval
        {
            get;
            set;
        }
    }
}
