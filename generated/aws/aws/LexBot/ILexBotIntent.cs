using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexBot
{
    [JsiiInterface(nativeType: typeof(ILexBotIntent), fullyQualifiedName: "aws.lexBot.LexBotIntent")]
    public interface ILexBotIntent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_name LexBot#intent_name}.</summary>
        [JsiiProperty(name: "intentName", typeJson: "{\"primitive\":\"string\"}")]
        string IntentName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_version LexBot#intent_version}.</summary>
        [JsiiProperty(name: "intentVersion", typeJson: "{\"primitive\":\"string\"}")]
        string IntentVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexBotIntent), fullyQualifiedName: "aws.lexBot.LexBotIntent")]
        internal sealed class _Proxy : DeputyBase, aws.LexBot.ILexBotIntent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_name LexBot#intent_name}.</summary>
            [JsiiProperty(name: "intentName", typeJson: "{\"primitive\":\"string\"}")]
            public string IntentName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_version LexBot#intent_version}.</summary>
            [JsiiProperty(name: "intentVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string IntentVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
