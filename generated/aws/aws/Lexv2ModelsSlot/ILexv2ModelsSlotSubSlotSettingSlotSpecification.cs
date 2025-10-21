using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotSubSlotSettingSlotSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecification")]
    public interface ILexv2ModelsSlotSubSlotSettingSlotSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#map_block_key Lexv2ModelsSlot#map_block_key}.</summary>
        [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
        string MapBlockKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_type_id Lexv2ModelsSlot#slot_type_id}.</summary>
        [JsiiProperty(name: "slotTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string SlotTypeId
        {
            get;
        }

        /// <summary>value_elicitation_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#value_elicitation_setting Lexv2ModelsSlot#value_elicitation_setting}
        /// </remarks>
        [JsiiProperty(name: "valueElicitationSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecificationValueElicitationSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValueElicitationSetting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotSubSlotSettingSlotSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotSubSlotSettingSlotSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#map_block_key Lexv2ModelsSlot#map_block_key}.</summary>
            [JsiiProperty(name: "mapBlockKey", typeJson: "{\"primitive\":\"string\"}")]
            public string MapBlockKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_type_id Lexv2ModelsSlot#slot_type_id}.</summary>
            [JsiiProperty(name: "slotTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string SlotTypeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value_elicitation_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#value_elicitation_setting Lexv2ModelsSlot#value_elicitation_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "valueElicitationSetting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecificationValueElicitationSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ValueElicitationSetting
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
