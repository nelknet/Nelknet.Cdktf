using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload")]
    public interface ILexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#value Lexv2ModelsIntent#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentInitialResponseSettingConditionalConditionalBranchResponseMessageGroupVariationCustomPayload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#value Lexv2ModelsIntent#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
