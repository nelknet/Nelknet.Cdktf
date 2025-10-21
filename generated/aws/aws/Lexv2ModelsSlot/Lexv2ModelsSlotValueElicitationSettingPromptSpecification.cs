using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecification")]
    public class Lexv2ModelsSlotValueElicitationSettingPromptSpecification : aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#max_retries Lexv2ModelsSlot#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRetries
        {
            get;
            set;
        }

        private object? _allowInterrupt;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#allow_interrupt Lexv2ModelsSlot#allow_interrupt}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#message_group Lexv2ModelsSlot#message_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messageGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _messageGroup = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#message_selection_strategy Lexv2ModelsSlot#message_selection_strategy}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#prompt_attempts_specification Lexv2ModelsSlot#prompt_attempts_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptAttemptsSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _promptAttemptsSpecification = value;
            }
        }
    }
}
