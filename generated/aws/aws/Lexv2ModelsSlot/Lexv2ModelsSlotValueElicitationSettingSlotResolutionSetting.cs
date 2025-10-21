using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsSlot.Lexv2ModelsSlotValueElicitationSettingSlotResolutionSetting")]
    public class Lexv2ModelsSlotValueElicitationSettingSlotResolutionSetting : aws.Lexv2ModelsSlot.ILexv2ModelsSlotValueElicitationSettingSlotResolutionSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_slot#slot_resolution_strategy Lexv2ModelsSlot#slot_resolution_strategy}.</summary>
        [JsiiProperty(name: "slotResolutionStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string SlotResolutionStrategy
        {
            get;
            set;
        }
    }
}
