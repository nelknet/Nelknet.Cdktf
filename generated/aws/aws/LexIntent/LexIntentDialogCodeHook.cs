using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentDialogCodeHook")]
    public class LexIntentDialogCodeHook : aws.LexIntent.ILexIntentDialogCodeHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#message_version LexIntent#message_version}.</summary>
        [JsiiProperty(name: "messageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string MessageVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#uri LexIntent#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }
    }
}
