using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotObfuscationSetting")]
    public class Lexv2ModelsSlotObfuscationSetting : aws.Lexv2ModelsSlot.ILexv2ModelsSlotObfuscationSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#obfuscation_setting_type Lexv2ModelsSlot#obfuscation_setting_type}.</summary>
        [JsiiProperty(name: "obfuscationSettingType", typeJson: "{\"primitive\":\"string\"}")]
        public string ObfuscationSettingType
        {
            get;
            set;
        }
    }
}
