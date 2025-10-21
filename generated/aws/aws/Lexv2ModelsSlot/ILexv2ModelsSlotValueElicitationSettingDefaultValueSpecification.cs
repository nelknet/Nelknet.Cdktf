using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecification")]
    public interface ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification
    {
        /// <summary>default_value_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#default_value_list Lexv2ModelsSlot#default_value_list}
        /// </remarks>
        [JsiiProperty(name: "defaultValueList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultValueList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingDefaultValueSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_value_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#default_value_list Lexv2ModelsSlot#default_value_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultValueList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingDefaultValueSpecificationDefaultValueListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultValueList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
