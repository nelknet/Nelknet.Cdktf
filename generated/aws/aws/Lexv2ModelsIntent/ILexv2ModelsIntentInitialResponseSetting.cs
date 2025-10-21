using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentInitialResponseSetting), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSetting")]
    public interface ILexv2ModelsIntentInitialResponseSetting
    {
        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#code_hook Lexv2ModelsIntent#code_hook}
        /// </remarks>
        [JsiiProperty(name: "codeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>conditional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#conditional Lexv2ModelsIntent#conditional}
        /// </remarks>
        [JsiiProperty(name: "conditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Conditional
        {
            get
            {
                return null;
            }
        }

        /// <summary>initial_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#initial_response Lexv2ModelsIntent#initial_response}
        /// </remarks>
        [JsiiProperty(name: "initialResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingInitialResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitialResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#next_step Lexv2ModelsIntent#next_step}
        /// </remarks>
        [JsiiProperty(name: "nextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NextStep
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentInitialResponseSetting), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#code_hook Lexv2ModelsIntent#code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeHook", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingCodeHook\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeHook
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>conditional block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#conditional Lexv2ModelsIntent#conditional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditional", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingConditional\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Conditional
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>initial_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#initial_response Lexv2ModelsIntent#initial_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initialResponse", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingInitialResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitialResponse
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>next_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#next_step Lexv2ModelsIntent#next_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NextStep
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
