using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotSubSlotSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSetting")]
    public interface ILexv2ModelsSlotSubSlotSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#expression Lexv2ModelsSlot#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>slot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_specification Lexv2ModelsSlot#slot_specification}
        /// </remarks>
        [JsiiProperty(name: "slotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SlotSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotSubSlotSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotSubSlotSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#expression Lexv2ModelsSlot#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>slot_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_specification Lexv2ModelsSlot#slot_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slotSpecification", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotSubSlotSettingSlotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlotSpecification
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
