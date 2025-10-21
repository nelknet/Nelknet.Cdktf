using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentFulfillmentActivity")]
    public class LexIntentFulfillmentActivity : aws.LexIntent.ILexIntentFulfillmentActivity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#type LexIntent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#code_hook LexIntent#code_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
        public aws.LexIntent.ILexIntentFulfillmentActivityCodeHook? CodeHook
        {
            get;
            set;
        }
    }
}
