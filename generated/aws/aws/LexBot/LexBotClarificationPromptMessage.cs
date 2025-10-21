using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexBot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexBot.LexBotClarificationPromptMessage")]
    public class LexBotClarificationPromptMessage : aws.LexBot.ILexBotClarificationPromptMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#content LexBot#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#content_type LexBot#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot#group_number LexBot#group_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupNumber
        {
            get;
            set;
        }
    }
}
