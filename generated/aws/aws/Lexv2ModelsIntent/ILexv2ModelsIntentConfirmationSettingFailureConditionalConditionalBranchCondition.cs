using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition")]
    public interface ILexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#expression_string Lexv2ModelsIntent#expression_string}.</summary>
        [JsiiProperty(name: "expressionString", typeJson: "{\"primitive\":\"string\"}")]
        string ExpressionString
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingFailureConditionalConditionalBranchCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#expression_string Lexv2ModelsIntent#expression_string}.</summary>
            [JsiiProperty(name: "expressionString", typeJson: "{\"primitive\":\"string\"}")]
            public string ExpressionString
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
