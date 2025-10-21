using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiInterface(nativeType: typeof(ILexIntentFulfillmentActivity), fullyQualifiedName: "aws.lexIntent.LexIntentFulfillmentActivity")]
    public interface ILexIntentFulfillmentActivity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#type LexIntent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#code_hook LexIntent#code_hook}
        /// </remarks>
        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentFulfillmentActivityCodeHook? CodeHook
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentFulfillmentActivity), fullyQualifiedName: "aws.lexIntent.LexIntentFulfillmentActivity")]
        internal sealed class _Proxy : DeputyBase, aws.LexIntent.ILexIntentFulfillmentActivity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#type LexIntent#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#code_hook LexIntent#code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentFulfillmentActivityCodeHook? CodeHook
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentFulfillmentActivityCodeHook?>();
            }
        }
    }
}
