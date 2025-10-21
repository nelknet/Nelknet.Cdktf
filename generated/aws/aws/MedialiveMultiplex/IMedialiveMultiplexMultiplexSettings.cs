using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplex
{
    [JsiiInterface(nativeType: typeof(IMedialiveMultiplexMultiplexSettings), fullyQualifiedName: "aws.medialiveMultiplex.MedialiveMultiplexMultiplexSettings")]
    public interface IMedialiveMultiplexMultiplexSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_bitrate MedialiveMultiplex#transport_stream_bitrate}.</summary>
        [JsiiProperty(name: "transportStreamBitrate", typeJson: "{\"primitive\":\"number\"}")]
        double TransportStreamBitrate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_id MedialiveMultiplex#transport_stream_id}.</summary>
        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
        double TransportStreamId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#maximum_video_buffer_delay_milliseconds MedialiveMultiplex#maximum_video_buffer_delay_milliseconds}.</summary>
        [JsiiProperty(name: "maximumVideoBufferDelayMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumVideoBufferDelayMilliseconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_reserved_bitrate MedialiveMultiplex#transport_stream_reserved_bitrate}.</summary>
        [JsiiProperty(name: "transportStreamReservedBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransportStreamReservedBitrate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveMultiplexMultiplexSettings), fullyQualifiedName: "aws.medialiveMultiplex.MedialiveMultiplexMultiplexSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveMultiplex.IMedialiveMultiplexMultiplexSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_bitrate MedialiveMultiplex#transport_stream_bitrate}.</summary>
            [JsiiProperty(name: "transportStreamBitrate", typeJson: "{\"primitive\":\"number\"}")]
            public double TransportStreamBitrate
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_id MedialiveMultiplex#transport_stream_id}.</summary>
            [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
            public double TransportStreamId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#maximum_video_buffer_delay_milliseconds MedialiveMultiplex#maximum_video_buffer_delay_milliseconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumVideoBufferDelayMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumVideoBufferDelayMilliseconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#transport_stream_reserved_bitrate MedialiveMultiplex#transport_stream_reserved_bitrate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportStreamReservedBitrate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransportStreamReservedBitrate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
