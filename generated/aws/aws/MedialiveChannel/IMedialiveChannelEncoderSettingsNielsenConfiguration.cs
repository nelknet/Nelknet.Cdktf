using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsNielsenConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration")]
    public interface IMedialiveChannelEncoderSettingsNielsenConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#distributor_id MedialiveChannel#distributor_id}.</summary>
        [JsiiProperty(name: "distributorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DistributorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_pcm_to_id3_tagging MedialiveChannel#nielsen_pcm_to_id3_tagging}.</summary>
        [JsiiProperty(name: "nielsenPcmToId3Tagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NielsenPcmToId3Tagging
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsNielsenConfiguration), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsNielsenConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsNielsenConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#distributor_id MedialiveChannel#distributor_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "distributorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DistributorId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_pcm_to_id3_tagging MedialiveChannel#nielsen_pcm_to_id3_tagging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nielsenPcmToId3Tagging", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NielsenPcmToId3Tagging
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
