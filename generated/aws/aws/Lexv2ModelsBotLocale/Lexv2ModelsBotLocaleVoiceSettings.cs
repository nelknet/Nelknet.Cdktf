using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBotLocale
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsBotLocale.Lexv2ModelsBotLocaleVoiceSettings")]
    public class Lexv2ModelsBotLocaleVoiceSettings : aws.Lexv2ModelsBotLocale.ILexv2ModelsBotLocaleVoiceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#voice_id Lexv2ModelsBotLocale#voice_id}.</summary>
        [JsiiProperty(name: "voiceId", typeJson: "{\"primitive\":\"string\"}")]
        public string VoiceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_locale#engine Lexv2ModelsBotLocale#engine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Engine
        {
            get;
            set;
        }
    }
}
