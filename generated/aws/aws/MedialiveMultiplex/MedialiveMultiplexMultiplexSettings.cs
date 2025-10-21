using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveMultiplex.MedialiveMultiplexMultiplexSettings")]
    public class MedialiveMultiplexMultiplexSettings : aws.MedialiveMultiplex.IMedialiveMultiplexMultiplexSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_bitrate MedialiveMultiplex#transport_stream_bitrate}.</summary>
        [JsiiProperty(name: "transportStreamBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public double TransportStreamBitrate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_id MedialiveMultiplex#transport_stream_id}.</summary>
        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
        public double TransportStreamId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#maximum_video_buffer_delay_milliseconds MedialiveMultiplex#maximum_video_buffer_delay_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumVideoBufferDelayMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumVideoBufferDelayMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_reserved_bitrate MedialiveMultiplex#transport_stream_reserved_bitrate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportStreamReservedBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TransportStreamReservedBitrate
        {
            get;
            set;
        }
    }
}
