using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentFollowUpPromptRejectionStatementMessage")]
    public class LexIntentFollowUpPromptRejectionStatementMessage : aws.LexIntent.ILexIntentFollowUpPromptRejectionStatementMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#content LexIntent#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#content_type LexIntent#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#group_number LexIntent#group_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupNumber
        {
            get;
            set;
        }
    }
}
