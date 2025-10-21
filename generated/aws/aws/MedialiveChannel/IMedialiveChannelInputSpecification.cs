using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputSpecification), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputSpecification")]
    public interface IMedialiveChannelInputSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec MedialiveChannel#codec}.</summary>
        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}")]
        string Codec
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_resolution MedialiveChannel#input_resolution}.</summary>
        [JsiiProperty(name: "inputResolution", typeJson: "{\"primitive\":\"string\"}")]
        string InputResolution
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maximum_bitrate MedialiveChannel#maximum_bitrate}.</summary>
        [JsiiProperty(name: "maximumBitrate", typeJson: "{\"primitive\":\"string\"}")]
        string MaximumBitrate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputSpecification), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#codec MedialiveChannel#codec}.</summary>
            [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}")]
            public string Codec
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#input_resolution MedialiveChannel#input_resolution}.</summary>
            [JsiiProperty(name: "inputResolution", typeJson: "{\"primitive\":\"string\"}")]
            public string InputResolution
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maximum_bitrate MedialiveChannel#maximum_bitrate}.</summary>
            [JsiiProperty(name: "maximumBitrate", typeJson: "{\"primitive\":\"string\"}")]
            public string MaximumBitrate
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
