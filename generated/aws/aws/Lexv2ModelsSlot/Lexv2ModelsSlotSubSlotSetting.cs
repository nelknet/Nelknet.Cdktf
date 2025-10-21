using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSetting")]
    public class Lexv2ModelsSlotSubSlotSetting : aws.Lexv2ModelsSlot.ILexv2ModelsSlotSubSlotSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#expression Lexv2ModelsSlot#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        private object? _slotSpecification;

        /// <summary>slot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_specification Lexv2ModelsSlot#slot_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SlotSpecification
        {
            get => _slotSpecification;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlot.ILexv2ModelsSlotSubSlotSettingSlotSpecification[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlot.ILexv2ModelsSlotSubSlotSettingSlotSpecification).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slotSpecification = value;
            }
        }
    }
}
