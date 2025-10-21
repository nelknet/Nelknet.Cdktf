using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection")]
    public interface IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_code MedialiveChannel#language_code}.</summary>
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        string LanguageCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_selection_policy MedialiveChannel#language_selection_policy}.</summary>
        [JsiiProperty(name: "languageSelectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LanguageSelectionPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_code MedialiveChannel#language_code}.</summary>
            [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
            public string LanguageCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#language_selection_policy MedialiveChannel#language_selection_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "languageSelectionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LanguageSelectionPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
