using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsBotVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsBotVersion.Lexv2ModelsBotVersionLocaleSpecification")]
    public class Lexv2ModelsBotVersionLocaleSpecification : aws.Lexv2ModelsBotVersion.ILexv2ModelsBotVersionLocaleSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_bot_version#source_bot_version Lexv2ModelsBotVersion#source_bot_version}.</summary>
        [JsiiProperty(name: "sourceBotVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceBotVersion
        {
            get;
            set;
        }
    }
}
