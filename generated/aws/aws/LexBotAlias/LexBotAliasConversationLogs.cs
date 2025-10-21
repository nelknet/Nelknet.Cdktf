using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexBotAlias
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexBotAlias.LexBotAliasConversationLogs")]
    public class LexBotAliasConversationLogs : aws.LexBotAlias.ILexBotAliasConversationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IamRoleArn
        {
            get;
            set;
        }

        private object? _logSettings;

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_bot_alias#log_settings LexBotAlias#log_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexBotAlias.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogSettings
        {
            get => _logSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LexBotAlias.ILexBotAliasConversationLogsLogSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LexBotAlias.ILexBotAliasConversationLogsLogSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logSettings = value;
            }
        }
    }
}
