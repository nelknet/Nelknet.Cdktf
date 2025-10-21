using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LexIntent
{
    [JsiiInterface(nativeType: typeof(ILexIntentSlot), fullyQualifiedName: "aws.lexIntent.LexIntentSlot")]
    public interface ILexIntentSlot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name LexIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_constraint LexIntent#slot_constraint}.</summary>
        [JsiiProperty(name: "slotConstraint", typeJson: "{\"primitive\":\"string\"}")]
        string SlotConstraint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type LexIntent#slot_type}.</summary>
        [JsiiProperty(name: "slotType", typeJson: "{\"primitive\":\"string\"}")]
        string SlotType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description LexIntent#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#priority LexIntent#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#response_card LexIntent#response_card}.</summary>
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseCard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SampleUtterances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type_version LexIntent#slot_type_version}.</summary>
        [JsiiProperty(name: "slotTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SlotTypeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>value_elicitation_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#value_elicitation_prompt LexIntent#value_elicitation_prompt}
        /// </remarks>
        [JsiiProperty(name: "valueElicitationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentSlotValueElicitationPrompt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LexIntent.ILexIntentSlotValueElicitationPrompt? ValueElicitationPrompt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentSlot), fullyQualifiedName: "aws.lexIntent.LexIntentSlot")]
        internal sealed class _Proxy : DeputyBase, aws.LexIntent.ILexIntentSlot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#name LexIntent#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_constraint LexIntent#slot_constraint}.</summary>
            [JsiiProperty(name: "slotConstraint", typeJson: "{\"primitive\":\"string\"}")]
            public string SlotConstraint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type LexIntent#slot_type}.</summary>
            [JsiiProperty(name: "slotType", typeJson: "{\"primitive\":\"string\"}")]
            public string SlotType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#description LexIntent#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#priority LexIntent#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#response_card LexIntent#response_card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseCard
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SampleUtterances
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#slot_type_version LexIntent#slot_type_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slotTypeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SlotTypeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>value_elicitation_prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lex_intent#value_elicitation_prompt LexIntent#value_elicitation_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "valueElicitationPrompt", typeJson: "{\"fqn\":\"aws.lexIntent.LexIntentSlotValueElicitationPrompt\"}", isOptional: true)]
            public aws.LexIntent.ILexIntentSlotValueElicitationPrompt? ValueElicitationPrompt
            {
                get => GetInstanceProperty<aws.LexIntent.ILexIntentSlotValueElicitationPrompt?>();
            }
        }
    }
}
