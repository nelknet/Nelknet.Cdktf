using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_ancillary_channel_number MedialiveChannel#source_ancillary_channel_number}.</summary>
        [JsiiProperty(name: "sourceAncillaryChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SourceAncillaryChannelNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_ancillary_channel_number MedialiveChannel#source_ancillary_channel_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAncillaryChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SourceAncillaryChannelNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
