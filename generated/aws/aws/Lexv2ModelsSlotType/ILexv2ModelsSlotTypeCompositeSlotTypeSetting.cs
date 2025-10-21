using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeCompositeSlotTypeSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSetting")]
    public interface ILexv2ModelsSlotTypeCompositeSlotTypeSetting
    {
        /// <summary>sub_slots block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sub_slots Lexv2ModelsSlotType#sub_slots}
        /// </remarks>
        [JsiiProperty(name: "subSlots", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSettingSubSlots\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubSlots
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeCompositeSlotTypeSetting), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeCompositeSlotTypeSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sub_slots block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sub_slots Lexv2ModelsSlotType#sub_slots}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subSlots", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeCompositeSlotTypeSettingSubSlots\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SubSlots
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
