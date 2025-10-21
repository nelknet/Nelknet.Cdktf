using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentConfirmationSetting), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSetting")]
    public interface ILexv2ModelsIntentConfirmationSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#active Lexv2ModelsIntent#active}.</summary>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#code_hook Lexv2ModelsIntent#code_hook}
        /// </remarks>
        [JsiiProperty(name: "codeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>confirmation_conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_conditional Lexv2ModelsIntent#confirmation_conditional}
        /// </remarks>
        [JsiiProperty(name: "confirmationConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfirmationConditional
        {
            get
            {
                return null;
            }
        }

        /// <summary>confirmation_next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_next_step Lexv2ModelsIntent#confirmation_next_step}
        /// </remarks>
        [JsiiProperty(name: "confirmationNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfirmationNextStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>confirmation_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_response Lexv2ModelsIntent#confirmation_response}
        /// </remarks>
        [JsiiProperty(name: "confirmationResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConfirmationResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>declination_conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_conditional Lexv2ModelsIntent#declination_conditional}
        /// </remarks>
        [JsiiProperty(name: "declinationConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeclinationConditional
        {
            get
            {
                return null;
            }
        }

        /// <summary>declination_next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_next_step Lexv2ModelsIntent#declination_next_step}
        /// </remarks>
        [JsiiProperty(name: "declinationNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeclinationNextStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>declination_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_response Lexv2ModelsIntent#declination_response}
        /// </remarks>
        [JsiiProperty(name: "declinationResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeclinationResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>elicitation_code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#elicitation_code_hook Lexv2ModelsIntent#elicitation_code_hook}
        /// </remarks>
        [JsiiProperty(name: "elicitationCodeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingElicitationCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ElicitationCodeHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>failure_conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_conditional Lexv2ModelsIntent#failure_conditional}
        /// </remarks>
        [JsiiProperty(name: "failureConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailureConditional
        {
            get
            {
                return null;
            }
        }

        /// <summary>failure_next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_next_step Lexv2ModelsIntent#failure_next_step}
        /// </remarks>
        [JsiiProperty(name: "failureNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailureNextStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>failure_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_response Lexv2ModelsIntent#failure_response}
        /// </remarks>
        [JsiiProperty(name: "failureResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailureResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>prompt_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#prompt_specification Lexv2ModelsIntent#prompt_specification}
        /// </remarks>
        [JsiiProperty(name: "promptSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PromptSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentConfirmationSetting), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#active Lexv2ModelsIntent#active}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#code_hook Lexv2ModelsIntent#code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeHook
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confirmation_conditional block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_conditional Lexv2ModelsIntent#confirmation_conditional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfirmationConditional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confirmation_next_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_next_step Lexv2ModelsIntent#confirmation_next_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfirmationNextStep
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confirmation_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#confirmation_response Lexv2ModelsIntent#confirmation_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ConfirmationResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>declination_conditional block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_conditional Lexv2ModelsIntent#declination_conditional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "declinationConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeclinationConditional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>declination_next_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_next_step Lexv2ModelsIntent#declination_next_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "declinationNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeclinationNextStep
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>declination_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#declination_response Lexv2ModelsIntent#declination_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "declinationResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingDeclinationResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeclinationResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>elicitation_code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#elicitation_code_hook Lexv2ModelsIntent#elicitation_code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elicitationCodeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingElicitationCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ElicitationCodeHook
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>failure_conditional block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_conditional Lexv2ModelsIntent#failure_conditional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureConditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailureConditional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>failure_next_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_next_step Lexv2ModelsIntent#failure_next_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureNextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailureNextStep
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>failure_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#failure_response Lexv2ModelsIntent#failure_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failureResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailureResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>prompt_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#prompt_specification Lexv2ModelsIntent#prompt_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "promptSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PromptSpecification
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
