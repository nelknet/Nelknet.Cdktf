using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentSampleUtterance), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSampleUtterance")]
    public interface ILexv2ModelsIntentSampleUtterance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#utterance Lexv2ModelsIntent#utterance}.</summary>
        [JsiiProperty(name: "utterance", typeJson: "{\"primitive\":\"string\"}")]
        string Utterance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentSampleUtterance), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSampleUtterance")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentSampleUtterance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#utterance Lexv2ModelsIntent#utterance}.</summary>
            [JsiiProperty(name: "utterance", typeJson: "{\"primitive\":\"string\"}")]
            public string Utterance
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
