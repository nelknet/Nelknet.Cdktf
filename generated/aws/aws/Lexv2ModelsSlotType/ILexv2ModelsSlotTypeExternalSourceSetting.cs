using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeExternalSourceSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSetting")]
    public interface ILexv2ModelsSlotTypeExternalSourceSetting
    {
        /// <summary>grammar_slot_type_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#grammar_slot_type_setting Lexv2ModelsSlotType#grammar_slot_type_setting}
        /// </remarks>
        [JsiiProperty(name: "grammarSlotTypeSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSettingGrammarSlotTypeSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GrammarSlotTypeSetting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeExternalSourceSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeExternalSourceSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grammar_slot_type_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#grammar_slot_type_setting Lexv2ModelsSlotType#grammar_slot_type_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grammarSlotTypeSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSettingGrammarSlotTypeSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GrammarSlotTypeSetting
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
