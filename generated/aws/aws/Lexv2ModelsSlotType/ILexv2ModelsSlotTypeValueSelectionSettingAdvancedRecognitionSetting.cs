using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting")]
    public interface ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#audio_recognition_strategy Lexv2ModelsSlotType#audio_recognition_strategy}.</summary>
        [JsiiProperty(name: "audioRecognitionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AudioRecognitionStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#audio_recognition_strategy Lexv2ModelsSlotType#audio_recognition_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioRecognitionStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AudioRecognitionStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
