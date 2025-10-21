using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecification")]
    public class Lexv2ModelsIntentConfirmationSettingPromptSpecification : aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#max_retries Lexv2ModelsIntent#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRetries
        {
            get;
            set;
        }

        private object? _allowInterrupt;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#allow_interrupt Lexv2ModelsIntent#allow_interrupt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowInterrupt", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowInterrupt
        {
            get => _allowInterrupt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowInterrupt = value;
            }
        }

        private object? _messageGroup;

        /// <summary>message_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#message_group Lexv2ModelsIntent#message_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MessageGroup
        {
            get => _messageGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _messageGroup = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#message_selection_strategy Lexv2ModelsIntent#message_selection_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageSelectionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageSelectionStrategy
        {
            get;
            set;
        }

        private object? _promptAttemptsSpecification;

        /// <summary>prompt_attempts_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#prompt_attempts_specification Lexv2ModelsIntent#prompt_attempts_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptAttemptsSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecificationPromptAttemptsSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PromptAttemptsSpecification
        {
            get => _promptAttemptsSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationPromptAttemptsSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationPromptAttemptsSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _promptAttemptsSpecification = value;
            }
        }
    }
}
