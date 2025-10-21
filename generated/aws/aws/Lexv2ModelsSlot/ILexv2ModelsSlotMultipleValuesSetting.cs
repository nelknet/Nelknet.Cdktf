using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotMultipleValuesSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotMultipleValuesSetting")]
    public interface ILexv2ModelsSlotMultipleValuesSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#allow_multiple_values Lexv2ModelsSlot#allow_multiple_values}.</summary>
        [JsiiProperty(name: "allowMultipleValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowMultipleValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotMultipleValuesSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotMultipleValuesSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotMultipleValuesSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#allow_multiple_values Lexv2ModelsSlot#allow_multiple_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowMultipleValues", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowMultipleValues
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
