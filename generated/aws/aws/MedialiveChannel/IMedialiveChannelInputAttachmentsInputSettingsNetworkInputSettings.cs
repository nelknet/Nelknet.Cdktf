using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings
    {
        /// <summary>hls_input_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_input_settings MedialiveChannel#hls_input_settings}
        /// </remarks>
        [JsiiProperty(name: "hlsInputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings? HlsInputSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#server_validation MedialiveChannel#server_validation}.</summary>
        [JsiiProperty(name: "serverValidation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerValidation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>hls_input_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#hls_input_settings MedialiveChannel#hls_input_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hlsInputSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings? HlsInputSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#server_validation MedialiveChannel#server_validation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverValidation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerValidation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
