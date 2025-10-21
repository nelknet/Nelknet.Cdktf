using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent")]
    public interface ILexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#name Lexv2ModelsIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>slot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot Lexv2ModelsIntent#slot}
        /// </remarks>
        [JsiiProperty(name: "slot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntentSlot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Slot
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#name Lexv2ModelsIntent#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>slot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot Lexv2ModelsIntent#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalConditionalBranchNextStepIntentSlot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Slot
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
