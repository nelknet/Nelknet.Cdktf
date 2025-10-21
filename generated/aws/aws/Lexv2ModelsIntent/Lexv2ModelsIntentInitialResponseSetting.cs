using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSetting")]
    public class Lexv2ModelsIntentInitialResponseSetting : aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSetting
    {
        private object? _codeHook;

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#code_hook Lexv2ModelsIntent#code_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeHook
        {
            get => _codeHook;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingCodeHook[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingCodeHook).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeHook = value;
            }
        }

        private object? _conditional;

        /// <summary>conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#conditional Lexv2ModelsIntent#conditional}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Conditional
        {
            get => _conditional;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingConditional[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingConditional).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditional = value;
            }
        }

        private object? _initialResponse;

        /// <summary>initial_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#initial_response Lexv2ModelsIntent#initial_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingInitialResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InitialResponse
        {
            get => _initialResponse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingInitialResponse[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingInitialResponse).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _initialResponse = value;
            }
        }

        private object? _nextStep;

        /// <summary>next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#next_step Lexv2ModelsIntent#next_step}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NextStep
        {
            get => _nextStep;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingNextStep[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingNextStep).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nextStep = value;
            }
        }
    }
}
