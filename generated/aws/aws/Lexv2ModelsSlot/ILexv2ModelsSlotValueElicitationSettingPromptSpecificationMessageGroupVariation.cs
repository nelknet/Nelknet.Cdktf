using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation")]
    public interface ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation
    {
        /// <summary>custom_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#custom_payload Lexv2ModelsSlot#custom_payload}
        /// </remarks>
        [JsiiProperty(name: "customPayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationCustomPayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomPayload
        {
            get
            {
                return null;
            }
        }

        /// <summary>image_response_card block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#image_response_card Lexv2ModelsSlot#image_response_card}
        /// </remarks>
        [JsiiProperty(name: "imageResponseCard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationImageResponseCard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageResponseCard
        {
            get
            {
                return null;
            }
        }

        /// <summary>plain_text_message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#plain_text_message Lexv2ModelsSlot#plain_text_message}
        /// </remarks>
        [JsiiProperty(name: "plainTextMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationPlainTextMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PlainTextMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssml_message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#ssml_message Lexv2ModelsSlot#ssml_message}
        /// </remarks>
        [JsiiProperty(name: "ssmlMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationSsmlMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SsmlMessage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#custom_payload Lexv2ModelsSlot#custom_payload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customPayload", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationCustomPayload\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomPayload
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>image_response_card block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#image_response_card Lexv2ModelsSlot#image_response_card}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageResponseCard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationImageResponseCard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ImageResponseCard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>plain_text_message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#plain_text_message Lexv2ModelsSlot#plain_text_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plainTextMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationPlainTextMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PlainTextMessage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ssml_message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#ssml_message Lexv2ModelsSlot#ssml_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmlMessage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationMessageGroupVariationSsmlMessage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SsmlMessage
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
