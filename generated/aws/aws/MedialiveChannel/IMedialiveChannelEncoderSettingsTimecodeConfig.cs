using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsTimecodeConfig), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig")]
    public interface IMedialiveChannelEncoderSettingsTimecodeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source MedialiveChannel#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sync_threshold MedialiveChannel#sync_threshold}.</summary>
        [JsiiProperty(name: "syncThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SyncThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsTimecodeConfig), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsTimecodeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsTimecodeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#source MedialiveChannel#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#sync_threshold MedialiveChannel#sync_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "syncThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SyncThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
