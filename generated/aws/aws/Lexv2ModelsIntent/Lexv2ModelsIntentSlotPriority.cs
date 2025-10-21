using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSlotPriority")]
    public class Lexv2ModelsIntentSlotPriority : aws.Lexv2ModelsIntent.ILexv2ModelsIntentSlotPriority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#priority Lexv2ModelsIntent#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#slot_id Lexv2ModelsIntent#slot_id}.</summary>
        [JsiiProperty(name: "slotId", typeJson: "{\"primitive\":\"string\"}")]
        public string SlotId
        {
            get;
            set;
        }
    }
}
