using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pid MedialiveChannel#pid}.</summary>
        [JsiiProperty(name: "pid", typeJson: "{\"primitive\":\"number\"}")]
        double Pid
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pid MedialiveChannel#pid}.</summary>
            [JsiiProperty(name: "pid", typeJson: "{\"primitive\":\"number\"}")]
            public double Pid
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
