using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexIntent.LexIntentSlot")]
    public class LexIntentSlot : aws.LexIntent.ILexIntentSlot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name LexIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_constraint LexIntent#slot_constraint}.</summary>
        [JsiiProperty(name: "slotConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public string SlotConstraint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type LexIntent#slot_type}.</summary>
        [JsiiProperty(name: "slotType", typeJson: "{\"primitive\":\"string\"}")]
        public string SlotType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description LexIntent#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#priority LexIntent#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#response_card LexIntent#response_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseCard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SampleUtterances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type_version LexIntent#slot_type_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slotTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SlotTypeVersion
        {
            get;
            set;
        }

        /// <summary>value_elicitation_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#value_elicitation_prompt LexIntent#value_elicitation_prompt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "valueElicitationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentSlotValueElicitationPrompt\"}", isOptional: true)]
        public aws.LexIntent.ILexIntentSlotValueElicitationPrompt? ValueElicitationPrompt
        {
            get;
            set;
        }
    }
}
