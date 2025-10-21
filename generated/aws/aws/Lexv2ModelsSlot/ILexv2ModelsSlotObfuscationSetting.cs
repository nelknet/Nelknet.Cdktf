using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsSlotObfuscationSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotObfuscationSetting")]
    public interface ILexv2ModelsSlotObfuscationSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#obfuscation_setting_type Lexv2ModelsSlot#obfuscation_setting_type}.</summary>
        [JsiiProperty(name: "obfuscationSettingType", typeJson: "{\"primitive\":\"string\"}")]
        string ObfuscationSettingType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsSlotObfuscationSetting), fullyQualifiedName: "aws.lexv2ModelsSlot.Lexv2ModelsSlotObfuscationSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsSlot.ILexv2ModelsSlotObfuscationSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#obfuscation_setting_type Lexv2ModelsSlot#obfuscation_setting_type}.</summary>
            [JsiiProperty(name: "obfuscationSettingType", typeJson: "{\"primitive\":\"string\"}")]
            public string ObfuscationSettingType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
