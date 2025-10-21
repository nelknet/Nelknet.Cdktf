using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct")]
    public interface ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#default_value Lexv2ModelsSlot#default_value}.</summary>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#default_value Lexv2ModelsSlot#default_value}.</summary>
            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
