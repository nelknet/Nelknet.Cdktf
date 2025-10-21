using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingSampleUtterance), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingSampleUtterance")]
    public interface ILexv2ModelsSlotValueElicitationSettingSampleUtterance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#utterance Lexv2ModelsSlot#utterance}.</summary>
        [JsiiProperty(name: "utterance", typeJson: "{\"primitive\":\"string\"}")]
        string Utterance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingSampleUtterance), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingSampleUtterance")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSampleUtterance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#utterance Lexv2ModelsSlot#utterance}.</summary>
            [JsiiProperty(name: "utterance", typeJson: "{\"primitive\":\"string\"}")]
            public string Utterance
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
