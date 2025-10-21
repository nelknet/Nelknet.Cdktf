using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeValueSelectionSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSetting")]
    public interface ILexv2ModelsSlotTypeValueSelectionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#resolution_strategy Lexv2ModelsSlotType#resolution_strategy}.</summary>
        [JsiiProperty(name: "resolutionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string ResolutionStrategy
        {
            get;
        }

        /// <summary>advanced_recognition_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#advanced_recognition_setting Lexv2ModelsSlotType#advanced_recognition_setting}
        /// </remarks>
        [JsiiProperty(name: "advancedRecognitionSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdvancedRecognitionSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>regex_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#regex_filter Lexv2ModelsSlotType#regex_filter}
        /// </remarks>
        [JsiiProperty(name: "regexFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingRegexFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RegexFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeValueSelectionSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#resolution_strategy Lexv2ModelsSlotType#resolution_strategy}.</summary>
            [JsiiProperty(name: "resolutionStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string ResolutionStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>advanced_recognition_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#advanced_recognition_setting Lexv2ModelsSlotType#advanced_recognition_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "advancedRecognitionSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdvancedRecognitionSetting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>regex_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#regex_filter Lexv2ModelsSlotType#regex_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regexFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingRegexFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RegexFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
