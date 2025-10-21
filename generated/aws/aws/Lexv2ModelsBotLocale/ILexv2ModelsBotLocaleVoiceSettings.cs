using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBotLocale
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsBotLocaleVoiceSettings), fullyQualifiedName: "aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings")]
    public interface ILexv2ModelsBotLocaleVoiceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#voice_id Lexv2ModelsBotLocale#voice_id}.</summary>
        [JsiiProperty(name: "voiceId", typeJson: "{\"primitive\":\"string\"}")]
        string VoiceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#engine Lexv2ModelsBotLocale#engine}.</summary>
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Engine
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsBotLocaleVoiceSettings), fullyQualifiedName: "aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleVoiceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#voice_id Lexv2ModelsBotLocale#voice_id}.</summary>
            [JsiiProperty(name: "voiceId", typeJson: "{\"primitive\":\"string\"}")]
            public string VoiceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#engine Lexv2ModelsBotLocale#engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Engine
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
