using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch")]
    public interface ILexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch
    {
        /// <summary>next_step block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#next_step Lexv2ModelsIntent#next_step}
        /// </remarks>
        [JsiiProperty(name: "nextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranchNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NextStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#response Lexv2ModelsIntent#response}
        /// </remarks>
        [JsiiProperty(name: "response", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranchResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Response
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>next_step block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#next_step Lexv2ModelsIntent#next_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nextStep", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranchNextStep\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NextStep
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#response Lexv2ModelsIntent#response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "response", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingCodeHookPostCodeHookSpecificationFailureConditionalDefaultBranchResponse\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Response
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
