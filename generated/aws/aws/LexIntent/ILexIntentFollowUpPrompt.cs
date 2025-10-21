using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiInterface(nativeType: typeof(ILexIntentFollowUpPrompt), fullyQualifiedName: "aws.lexIntent.LexIntentFollowUpPrompt")]
    public interface ILexIntentFollowUpPrompt
    {
        /// <summary>prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#prompt LexIntent#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPrompt\"}")]
        aws.LexIntent.ILexIntentFollowUpPromptPrompt Prompt
        {
            get;
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatement\"}")]
        aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentFollowUpPrompt), fullyQualifiedName: "aws.lexIntent.LexIntentFollowUpPrompt")]
        internal sealed class _Proxy : DeputyBase, aws.LexIntent.ILexIntentFollowUpPrompt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#prompt LexIntent#prompt}
            /// </remarks>
            [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptPrompt\"}")]
            public aws.LexIntent.ILexIntentFollowUpPromptPrompt Prompt
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPromptPrompt>()!;
            }

            /// <summary>rejection_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#rejection_statement LexIntent#rejection_statement}
            /// </remarks>
            [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFollowUpPromptRejectionStatement\"}")]
            public aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentFollowUpPromptRejectionStatement>()!;
            }
        }
    }
}
