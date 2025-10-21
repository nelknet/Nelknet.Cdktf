using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlotType
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotTypeSlotTypeValues), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValues")]
    public interface ILexv2ModelsSlotTypeSlotTypeValues
    {
        /// <summary>sample_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sample_value Lexv2ModelsSlotType#sample_value}
        /// </remarks>
        [JsiiProperty(name: "sampleValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSampleValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SampleValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>synonyms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#synonyms Lexv2ModelsSlotType#synonyms}
        /// </remarks>
        [JsiiProperty(name: "synonyms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSynonyms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Synonyms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotTypeSlotTypeValues), fullyQualifiedName: "aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValues")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlotType.ILexv2ModelsSlotTypeSlotTypeValues
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sample_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#sample_value Lexv2ModelsSlotType#sample_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sampleValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSampleValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SampleValue
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>synonyms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot_type#synonyms Lexv2ModelsSlotType#synonyms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "synonyms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlotType.Lexv2ModelsSlotTypeSlotTypeValuesSynonyms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Synonyms
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
