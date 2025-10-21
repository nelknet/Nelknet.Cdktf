using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeSlotTypeValuesSynonyms), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSynonyms")]
    public interface ILexv2ModelsSlotTypeSlotTypeValuesSynonyms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#value Lexv2ModelsSlotType#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeSlotTypeValuesSynonyms), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSynonyms")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValuesSynonyms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#value Lexv2ModelsSlotType#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
