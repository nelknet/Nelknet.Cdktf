using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsVideoSelector), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsVideoSelector")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsVideoSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space MedialiveChannel#color_space}.</summary>
        [JsiiProperty(name: "colorSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColorSpace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space_usage MedialiveChannel#color_space_usage}.</summary>
        [JsiiProperty(name: "colorSpaceUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColorSpaceUsage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsVideoSelector), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsVideoSelector")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsVideoSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space MedialiveChannel#color_space}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "colorSpace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColorSpace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#color_space_usage MedialiveChannel#color_space_usage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "colorSpaceUsage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColorSpaceUsage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
