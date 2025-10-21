using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexBot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexBot.LexBotIntent")]
    public class LexBotIntent : aws.LexBot.ILexBotIntent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_name LexBot#intent_name}.</summary>
        [JsiiProperty(name: "intentName", typeJson: "{\"primitive\":\"string\"}")]
        public string IntentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#intent_version LexBot#intent_version}.</summary>
        [JsiiProperty(name: "intentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string IntentVersion
        {
            get;
            set;
        }
    }
}
