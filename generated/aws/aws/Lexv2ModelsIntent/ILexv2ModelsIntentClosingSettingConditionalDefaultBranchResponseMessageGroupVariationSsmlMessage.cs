using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage")]
    public interface ILexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#value Lexv2ModelsIntent#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentClosingSettingConditionalDefaultBranchResponseMessageGroupVariationSsmlMessage
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
