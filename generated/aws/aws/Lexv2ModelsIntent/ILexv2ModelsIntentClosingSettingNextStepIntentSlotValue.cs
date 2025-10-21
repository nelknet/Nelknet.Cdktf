using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentClosingSettingNextStepIntentSlotValue), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepIntentSlotValue")]
    public interface ILexv2ModelsIntentClosingSettingNextStepIntentSlotValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#interpreted_value Lexv2ModelsIntent#interpreted_value}.</summary>
        [JsiiProperty(name: "interpretedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterpretedValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentClosingSettingNextStepIntentSlotValue), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingNextStepIntentSlotValue")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingNextStepIntentSlotValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#interpreted_value Lexv2ModelsIntent#interpreted_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interpretedValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterpretedValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
