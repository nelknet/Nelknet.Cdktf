using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentFollowUpPrompt")]
    public class LexIntentFollowUpPrompt : aws.LexIntent.ILexIntentFollowUpPrompt
    {
        /// <summary>prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#prompt LexIntent#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPrompt\"}")]
        public aws.LexIntent.ILexIntentFollowUpPromptPrompt Prompt
        {
            get;
            set;
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatement\"}")]
        public aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
        {
            get;
            set;
        }
    }
}
