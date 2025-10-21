using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelDestinationsMediaPackageSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinationsMediaPackageSettings")]
    public interface IMedialiveChannelDestinationsMediaPackageSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_id MedialiveChannel#channel_id}.</summary>
        [JsiiProperty(name: "channelId", typeJson: "{\"primitive\":\"string\"}")]
        string ChannelId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelDestinationsMediaPackageSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinationsMediaPackageSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelDestinationsMediaPackageSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#channel_id MedialiveChannel#channel_id}.</summary>
            [JsiiProperty(name: "channelId", typeJson: "{\"primitive\":\"string\"}")]
            public string ChannelId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
