using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentSlotPriority), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSlotPriority")]
    public interface ILexv2ModelsIntentSlotPriority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#priority Lexv2ModelsIntent#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot_id Lexv2ModelsIntent#slot_id}.</summary>
        [JsiiProperty(name: "slotId", typeJson: "{\"primitive\":\"string\"}")]
        string SlotId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentSlotPriority), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSlotPriority")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentSlotPriority
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#priority Lexv2ModelsIntent#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot_id Lexv2ModelsIntent#slot_id}.</summary>
            [JsiiProperty(name: "slotId", typeJson: "{\"primitive\":\"string\"}")]
            public string SlotId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
