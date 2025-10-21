using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSetting")]
    public class Lexv2ModelsSlotTypeValueSelectionSetting : aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#resolution_strategy Lexv2ModelsSlotType#resolution_strategy}.</summary>
        [JsiiProperty(name: "resolutionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string ResolutionStrategy
        {
            get;
            set;
        }

        private object? _advancedRecognitionSetting;

        /// <summary>advanced_recognition_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#advanced_recognition_setting Lexv2ModelsSlotType#advanced_recognition_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "advancedRecognitionSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdvancedRecognitionSetting
        {
            get => _advancedRecognitionSetting;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSettingAdvancedRecognitionSetting).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _advancedRecognitionSetting = value;
            }
        }

        private object? _regexFilter;

        /// <summary>regex_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#regex_filter Lexv2ModelsSlotType#regex_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regexFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeValueSelectionSettingRegexFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RegexFilter
        {
            get => _regexFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSettingRegexFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeValueSelectionSettingRegexFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _regexFilter = value;
            }
        }
    }
}
