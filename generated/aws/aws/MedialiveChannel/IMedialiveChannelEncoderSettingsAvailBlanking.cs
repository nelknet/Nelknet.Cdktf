using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsAvailBlanking), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking")]
    public interface IMedialiveChannelEncoderSettingsAvailBlanking
    {
        /// <summary>avail_blanking_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking_image MedialiveChannel#avail_blanking_image}
        /// </remarks>
        [JsiiProperty(name: "availBlankingImage", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsAvailBlanking), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlanking")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlanking
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>avail_blanking_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#avail_blanking_image MedialiveChannel#avail_blanking_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availBlankingImage", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsAvailBlankingAvailBlankingImage?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#state MedialiveChannel#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
