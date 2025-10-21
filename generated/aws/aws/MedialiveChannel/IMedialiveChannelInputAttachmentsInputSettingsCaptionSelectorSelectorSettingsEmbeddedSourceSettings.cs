using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#convert_608_to_708 MedialiveChannel#convert_608_to_708}.</summary>
        [JsiiProperty(name: "convert608To708", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Convert608To708
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte20_detection MedialiveChannel#scte20_detection}.</summary>
        [JsiiProperty(name: "scte20Detection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scte20Detection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_608_channel_number MedialiveChannel#source_608_channel_number}.</summary>
        [JsiiProperty(name: "source608ChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Source608ChannelNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#convert_608_to_708 MedialiveChannel#convert_608_to_708}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "convert608To708", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Convert608To708
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte20_detection MedialiveChannel#scte20_detection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scte20Detection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scte20Detection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source_608_channel_number MedialiveChannel#source_608_channel_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "source608ChannelNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Source608ChannelNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
