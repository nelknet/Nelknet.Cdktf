using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBotVersion
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsBotVersionLocaleSpecification), fullyQualifiedName: "aws.lexv2ModelsBotVersion.Lexv2ModelsBotVersionLocaleSpecification")]
    public interface ILexv2ModelsBotVersionLocaleSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#source_bot_version Lexv2ModelsBotVersion#source_bot_version}.</summary>
        [JsiiProperty(name: "sourceBotVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceBotVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsBotVersionLocaleSpecification), fullyQualifiedName: "aws.lexv2ModelsBotVersion.Lexv2ModelsBotVersionLocaleSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsBotVersion.ILexv2ModelsBotVersionLocaleSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#source_bot_version Lexv2ModelsBotVersion#source_bot_version}.</summary>
            [JsiiProperty(name: "sourceBotVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceBotVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
