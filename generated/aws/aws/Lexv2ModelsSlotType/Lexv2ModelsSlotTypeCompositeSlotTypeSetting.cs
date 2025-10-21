using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiByValue(fqn: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSetting")]
    public class Lexv2ModelsSlotTypeCompositeSlotTypeSetting : aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeCompositeSlotTypeSetting
    {
        private object? _subSlots;

        /// <summary>sub_slots block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sub_slots Lexv2ModelsSlotType#sub_slots}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subSlots", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSettingSubSlots\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SubSlots
        {
            get => _subSlots;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeCompositeSlotTypeSettingSubSlots[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeCompositeSlotTypeSettingSubSlots).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subSlots = value;
            }
        }
    }
}
