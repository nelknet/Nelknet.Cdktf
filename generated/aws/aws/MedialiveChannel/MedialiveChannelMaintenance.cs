using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveChannel.MedialiveChannelMaintenance")]
    public class MedialiveChannelMaintenance : aws.MedialiveChannel.IMedialiveChannelMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_day MedialiveChannel#maintenance_day}.</summary>
        [JsiiProperty(name: "maintenanceDay", typeJson: "{\"primitive\":\"string\"}")]
        public string MaintenanceDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_start_time MedialiveChannel#maintenance_start_time}.</summary>
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public string MaintenanceStartTime
        {
            get;
            set;
        }
    }
}
