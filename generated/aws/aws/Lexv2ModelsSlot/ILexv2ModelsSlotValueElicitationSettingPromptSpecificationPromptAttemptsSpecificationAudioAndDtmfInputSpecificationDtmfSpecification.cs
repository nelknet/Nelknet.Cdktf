using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification")]
    public interface ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#deletion_character Lexv2ModelsSlot#deletion_character}.</summary>
        [JsiiProperty(name: "deletionCharacter", typeJson: "{\"primitive\":\"string\"}")]
        string DeletionCharacter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#end_character Lexv2ModelsSlot#end_character}.</summary>
        [JsiiProperty(name: "endCharacter", typeJson: "{\"primitive\":\"string\"}")]
        string EndCharacter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#end_timeout_ms Lexv2ModelsSlot#end_timeout_ms}.</summary>
        [JsiiProperty(name: "endTimeoutMs", typeJson: "{\"primitive\":\"number\"}")]
        double EndTimeoutMs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#max_length Lexv2ModelsSlot#max_length}.</summary>
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}")]
        double MaxLength
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingPromptSpecificationPromptAttemptsSpecificationAudioAndDtmfInputSpecificationDtmfSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#deletion_character Lexv2ModelsSlot#deletion_character}.</summary>
            [JsiiProperty(name: "deletionCharacter", typeJson: "{\"primitive\":\"string\"}")]
            public string DeletionCharacter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#end_character Lexv2ModelsSlot#end_character}.</summary>
            [JsiiProperty(name: "endCharacter", typeJson: "{\"primitive\":\"string\"}")]
            public string EndCharacter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#end_timeout_ms Lexv2ModelsSlot#end_timeout_ms}.</summary>
            [JsiiProperty(name: "endTimeoutMs", typeJson: "{\"primitive\":\"number\"}")]
            public double EndTimeoutMs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#max_length Lexv2ModelsSlot#max_length}.</summary>
            [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxLength
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
