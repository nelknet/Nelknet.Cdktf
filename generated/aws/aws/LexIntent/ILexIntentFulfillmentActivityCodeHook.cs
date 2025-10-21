using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiInterface(nativeType: typeof(ILexIntentFulfillmentActivityCodeHook), fullyQualifiedName: "aws.lexIntent.LexIntentFulfillmentActivityCodeHook")]
    public interface ILexIntentFulfillmentActivityCodeHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#message_version LexIntent#message_version}.</summary>
        [JsiiProperty(name: "messageVersion", typeJson: "{\"primitive\":\"string\"}")]
        string MessageVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#uri LexIntent#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentFulfillmentActivityCodeHook), fullyQualifiedName: "aws.lexIntent.LexIntentFulfillmentActivityCodeHook")]
        internal sealed class _Proxy : DeputyBase, aws.LexIntent.ILexIntentFulfillmentActivityCodeHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#message_version LexIntent#message_version}.</summary>
            [JsiiProperty(name: "messageVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string MessageVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#uri LexIntent#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
