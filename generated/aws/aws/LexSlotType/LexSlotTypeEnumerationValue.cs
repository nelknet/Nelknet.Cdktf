using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexSlotType
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexSlotType.LexSlotTypeEnumerationValue")]
    public class LexSlotTypeEnumerationValue : aws.LexSlotType.ILexSlotTypeEnumerationValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#value LexSlotType#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_slot_type#synonyms LexSlotType#synonyms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "synonyms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Synonyms
        {
            get;
            set;
        }
    }
}
