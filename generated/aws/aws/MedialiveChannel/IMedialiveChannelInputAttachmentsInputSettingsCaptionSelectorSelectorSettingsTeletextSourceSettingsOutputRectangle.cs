using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height MedialiveChannel#height}.</summary>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        double Height
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#left_offset MedialiveChannel#left_offset}.</summary>
        [JsiiProperty(name: "leftOffset", typeJson: "{\"primitive\":\"number\"}")]
        double LeftOffset
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#top_offset MedialiveChannel#top_offset}.</summary>
        [JsiiProperty(name: "topOffset", typeJson: "{\"primitive\":\"number\"}")]
        double TopOffset
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#width MedialiveChannel#width}.</summary>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        double Width
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#height MedialiveChannel#height}.</summary>
            [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
            public double Height
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#left_offset MedialiveChannel#left_offset}.</summary>
            [JsiiProperty(name: "leftOffset", typeJson: "{\"primitive\":\"number\"}")]
            public double LeftOffset
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#top_offset MedialiveChannel#top_offset}.</summary>
            [JsiiProperty(name: "topOffset", typeJson: "{\"primitive\":\"number\"}")]
            public double TopOffset
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#width MedialiveChannel#width}.</summary>
            [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
            public double Width
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
