using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentSlotValueElicitationPrompt")]
    public class LexIntentSlotValueElicitationPrompt : aws.LexIntent.ILexIntentSlotValueElicitationPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#max_attempts LexIntent#max_attempts}.</summary>
        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxAttempts
        {
            get;
            set;
        }

        private object _message;

        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#message LexIntent#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexIntent.LexIntentSlotValueElicitationPromptMessage\"},\"kind\":\"array\"}}]}}")]
        public object Message
        {
            get => _message;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LexIntent.ILexIntentSlotValueElicitationPromptMessage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LexIntent.ILexIntentSlotValueElicitationPromptMessage).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LexIntent.ILexIntentSlotValueElicitationPromptMessage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _message = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#response_card LexIntent#response_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseCard
        {
            get;
            set;
        }
    }
}
