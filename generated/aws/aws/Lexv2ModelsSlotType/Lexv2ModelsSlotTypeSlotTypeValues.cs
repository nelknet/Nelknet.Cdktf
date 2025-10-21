using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiByValue(fqn: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValues")]
    public class Lexv2ModelsSlotTypeSlotTypeValues : aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValues
    {
        private object? _sampleValue;

        /// <summary>sample_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sample_value Lexv2ModelsSlotType#sample_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sampleValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSampleValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SampleValue
        {
            get => _sampleValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValuesSampleValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValuesSampleValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sampleValue = value;
            }
        }

        private object? _synonyms;

        /// <summary>synonyms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#synonyms Lexv2ModelsSlotType#synonyms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "synonyms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSynonyms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Synonyms
        {
            get => _synonyms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValuesSynonyms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValuesSynonyms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _synonyms = value;
            }
        }
    }
}
