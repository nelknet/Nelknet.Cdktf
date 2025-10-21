using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexSlotType
{
    [JsiiInterface(nativeType: typeof(ILexSlotTypeEnumerationValue), fullyQualifiedName: "aws.lexSlotType.LexSlotTypeEnumerationValue")]
    public interface ILexSlotTypeEnumerationValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#value LexSlotType#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#synonyms LexSlotType#synonyms}.</summary>
        [JsiiProperty(name: "synonyms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Synonyms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexSlotTypeEnumerationValue), fullyQualifiedName: "aws.lexSlotType.LexSlotTypeEnumerationValue")]
        internal sealed class _Proxy : DeputyBase, aws.LexSlotType.ILexSlotTypeEnumerationValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#value LexSlotType#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#synonyms LexSlotType#synonyms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "synonyms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Synonyms
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
