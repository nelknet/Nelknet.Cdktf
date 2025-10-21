using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiByValue(fqn: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSetting")]
    public class Lexv2ModelsSlotTypeExternalSourceSetting : aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeExternalSourceSetting
    {
        private object? _grammarSlotTypeSetting;

        /// <summary>grammar_slot_type_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#grammar_slot_type_setting Lexv2ModelsSlotType#grammar_slot_type_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grammarSlotTypeSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeExternalSourceSettingGrammarSlotTypeSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GrammarSlotTypeSetting
        {
            get => _grammarSlotTypeSetting;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeExternalSourceSettingGrammarSlotTypeSetting[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeExternalSourceSettingGrammarSlotTypeSetting).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grammarSlotTypeSetting = value;
            }
        }
    }
}
