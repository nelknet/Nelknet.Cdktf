using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings")]
    public interface IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#style_control MedialiveChannel#style_control}.</summary>
        [JsiiProperty(name: "styleControl", typeJson: "{\"primitive\":\"string\"}")]
        string StyleControl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#style_control MedialiveChannel#style_control}.</summary>
            [JsiiProperty(name: "styleControl", typeJson: "{\"primitive\":\"string\"}")]
            public string StyleControl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
