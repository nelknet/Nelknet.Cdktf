using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexBotAlias
{
    [JsiiInterface(nativeType: typeof(ILexBotAliasConversationLogs), fullyQualifiedName: "aws.lexBotAlias.LexBotAliasConversationLogs")]
    public interface ILexBotAliasConversationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string IamRoleArn
        {
            get;
        }

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#log_settings LexBotAlias#log_settings}
        /// </remarks>
        [JsiiProperty(name: "logSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexBotAlias.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexBotAliasConversationLogs), fullyQualifiedName: "aws.lexBotAlias.LexBotAliasConversationLogs")]
        internal sealed class _Proxy : DeputyBase, aws.LexBotAlias.ILexBotAliasConversationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
            [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IamRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>log_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#log_settings LexBotAlias#log_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexBotAlias.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogSettings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
